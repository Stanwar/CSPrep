using System;

namespace CSPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(10,15);

            // Add graph edges 
            graph.AddEdge(1,2);
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
