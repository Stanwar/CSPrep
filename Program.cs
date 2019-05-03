using System;

namespace CSPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            string postFixString = "ab+ef*g*-";
            binaryTree.ExpressionTree(postFixString);
        }

        // Graph Adjacency List with Node class
        static void GraphAdjList(){
            GraphAdjList graph = new GraphAdjList(10);
            graph.AddVertex(1,20);
            graph.AddVertex(2,20);
            graph.AddVertex(3,20);
            graph.AddVertex(4,20);
            graph.AddVertex(5,20);
            graph.AddVertex(6,20);

            graph.AddEdge(1,5);
            graph.AddEdge(3,4);
            graph.AddEdge(5,2);
            graph.AddEdge(3,2);
            graph.AddEdge(1,4);
            
            graph.PrintGraph();
        }
        // Graph Adjacency Matrix 
        static void GraphAdjMatrix(){
            Graph graph = new Graph(10,15);

            // Add graph edges 
            graph.AddEdge(0,1);
            graph.AddEdge(0,10);
            graph.AddEdge(2,1);
            graph.AddEdge(3,1);
            graph.AddEdge(1,2);
            graph.AddEdge(1,10);
            graph.AddEdge(2,3);
            graph.AddEdge(3,4);
            graph.AddEdge(9,12);
            graph.AddEdge(8,7);
            graph.AddEdge(7,8);
            graph.AddEdge(4,5);
            graph.AddEdge(7,6);
            graph.AddEdge(3,7);
            graph.AddEdge(1,5);
            graph.AddEdge(1,6);
            graph.AddEdge(8,9);
            graph.AddEdge(9,5);
            graph.AddEdge(6,7);
            graph.AddEdge(5,2);

            graph.PrintGraphComponents();
        }
    }
}
