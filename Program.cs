using System;

namespace CSPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(10,15);
            Console.WriteLine(graph.rows.Capacity);
            Console.WriteLine(graph.columns.Capacity);
            Console.WriteLine("HELL");
        }
    }
}
