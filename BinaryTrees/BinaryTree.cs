using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class BinaryTree {

    public void PrintInOrder(TreeNode root){

        if (root == null){
            return;
        }
        PrintInOrder(root.Left);
        Console.Write(root.Indentifier + " ");
        PrintInOrder(root.Right);
    }

    public void InsertLevelOrder(TreeNode root, int key){
        // We will use BFS. Define a queue 
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        // Go over queue till we find a place to add the new element 
        while (queue.Count > 0) {
            TreeNode node;

            // Get Top node.
            if (queue.TryDequeue(out node)){
                
            }
            else{
                node = new TreeNode(key);
                break;
            }

            // Check if the left node is null
            if (node.Left == null) {
                node.Left = new TreeNode(key);
                break;
            }
            // Otherwise add to queue
            else{
                queue.Enqueue(node.Left);
            }

            // Check if the right node is null
            if (node.Right == null) {
                node.Right = new TreeNode(key);
                break;
            }
            // Otherwise add to queue
            else{
                queue.Enqueue(node.Right);
            }
        }
    }

    // Delete a node from a binary tree
    public void DeleteBinaryTree(TreeNode root, int key){

        if (root == null || key == 0) {
            Console.WriteLine("Please enter clean input");
            return;
        }
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        TreeNode toBeDeleted = null;
        TreeNode rightMost = null;
        bool isRoot = false;
        bool isLeft = false;
        bool isRight = false;

        // Get right most node which will replace the node to be deleted 
        while (queue.Count > 0) {
            TreeNode node;
            if (queue.TryDequeue(out node)) {
                rightMost = node;
                // Condition for root
                if (node.Indentifier == root.Indentifier && node.Indentifier == key) {
                    isRoot = true;
                    toBeDeleted = node;
                }

                if (node.Left != null ){
                    if (node.Left.Indentifier == key) {
                        isLeft = true;
                        toBeDeleted = node;
                    }
                    else{
                        queue.Enqueue(node.Left);
                    }
                }

                if (node.Right != null){
                    if (node.Right.Indentifier == key) {
                        isRight = true;
                        toBeDeleted = node;
                    }
                    else{
                        queue.Enqueue(node.Right);
                    }
                }
            }

            if (queue.Count == 0) {
                node = null;
            }
        }

        if (toBeDeleted == null) {
            Console.WriteLine("Key not found!");
        }

        if (toBeDeleted != null && rightMost != null) {
            if (isRoot) {
                toBeDeleted.Indentifier = rightMost.Indentifier;
            }

            if (isLeft) {
                toBeDeleted.Left.Indentifier = rightMost.Indentifier;
            }
            else if (isRight){
                toBeDeleted.Right.Indentifier = rightMost.Indentifier;
            }
        }
    }

    // Check if the given tree is continuous or not. 
    public bool TreeContinuous(TreeNode root){

        if (root == null){
            return true;
        }

        // Only one node. 
        if (root.Left == null && root.Right == null) {
            return true;
        }

        // If left node is null, check right
        if (root.Left == null) {
            return ( Math.Abs(root.Indentifier - root.Right.Indentifier) ==  1 ) && TreeContinuous(root.Right);
        }

        // If right node is null, check left
        if (root.Right == null) {
            return ( Math.Abs(root.Indentifier - root.Left.Indentifier) == 1 ) && TreeContinuous(root.Left);
        }

        // Check everything.
        return (
                Math.Abs(root.Indentifier - root.Left.Indentifier) == 1 
             && Math.Abs(root.Indentifier - root.Right.Indentifier) == 1 
             && TreeContinuous(root.Left)
             && TreeContinuous(root.Right)
             );
    }

    public TreeNode MirrorBinaryTree(TreeNode root){

        if (root == null) {
            return root;
        }

        TreeNode left = MirrorBinaryTree(root.Left);
        TreeNode right = MirrorBinaryTree(root.Right);

        var temp = left;
        left = right;
        right = temp;
        
        return root;
    }

    public TreeNode MirrorIterativeBinaryTree(TreeNode root){

        if (root == null) {
            return root;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0){
            TreeNode node;
            if (queue.TryDequeue(out node)) {
                // Swap

                TreeNode temp = node.Left;
                node.Left = node.Right;
                node.Right = temp;

                if (node.Left != null){
                    queue.Enqueue(node.Left);
                }
                
                if (node.Right != null) {
                    queue.Enqueue(node.Right);
                }
            }
        }

        return root;
    }
}