using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
class Node{
    private int _Indentifier;
    public int Indentifier {
        get{
            return _Indentifier;
        }

        set{
            _Indentifier = value;
        }
    }

    public Node Left = null;
    public Node Right = null;

    public Node (int id){
        Indentifier = id;
    }
}

class BinaryTree {

    public void PrintInOrder(int[] arr){

    }

    public void InsertLevelOrder(Node root, int key){
        // We will use BFS. Define a queue 
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        // Go over queue till we find a place to add the new element 
        while (queue.Count > 0) {
            Node node;

            // Get Top node.
            if (queue.TryDequeue(out node)){
                
            }
            else{
                node = new Node(key);
                break;
            }

            // Check if the left node is null
            if (node.Left == null) {
                node.Left = new Node(key);
                break;
            }
            // Otherwise add to queue
            else{
                queue.Enqueue(node.Left);
            }

            // Check if the right node is null
            if (node.Right == null) {
                node.Right = new Node(key);
                break;
            }
            // Otherwise add to queue
            else{
                queue.Enqueue(node.Right);
            }
        }
    }
}