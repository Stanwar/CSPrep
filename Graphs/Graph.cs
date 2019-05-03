// Various representations for graphs
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

internal class Graph{
    public List<List<int>> Edges;

    // Constructors
    public Graph() {
        // Initialize graph to 10 r/c
        this.Edges = new List<List<int>>();
        this.Edges.Capacity = 10;
    }

    public Graph(int v){
        this.Edges = new List<List<int>>();
        for (var i=0;i<v; i++) {
            this.Edges.Add(new List<int>());
        }
        this.Edges.Capacity = v;
    }

    public Graph(int r, int c) {
        this.Edges = new List<List<int>>();

        for(var i=0;i< r;i++){
            var e = new List<int>();
            e.Capacity = c;
            for(var x = 0; x < e.Capacity ;++x){
                e.Add(0);
            }
            this.Edges.Add(e);
        }
        this.Edges.Capacity = r;
    }

    public void AddEdge(int source, int destination){
        this.Edges[source][destination] = 1;
    }

    public void PrintGraphComponents(){
        Console.WriteLine(Edges.Capacity);
        for (var i=0;i<Edges.Capacity; i++) {
            var edge = Edges[i];
            StringBuilder sb = new StringBuilder();

            for (var j=0;j<edge.Capacity;j++){
                sb.Append(edge[j] + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

internal class GraphNode {
    internal int identifier {get;set;}
    internal int weight {get;set;}
    internal List<GraphNode> neighbors = new List<GraphNode>();
    internal GraphNode () {
        
    }

    internal GraphNode (int id, int w) {
        identifier = id;
        weight = w;
    }
}

internal class GraphAdjList {
    int vertices {get;set;}
    Dictionary<int,GraphNode> GraphNodes = new Dictionary<int, GraphNode>();
    public GraphAdjList(int v) {
        vertices = v;
    }

    public void AddVertex(int id, int weight){
        GraphNode vertex = new GraphNode(id, weight);
        GraphNodes.Add(vertex.identifier, vertex);
    }

    public void AddEdge(int s, int d){
        var source = GraphNodes[s];
        var destination = GraphNodes[d];
        source.neighbors.Add(destination);
    }

    public void PrintGraph(){
        foreach (KeyValuePair<int, GraphNode> GraphNode in GraphNodes) {
            var neighbors = GraphNode.Value.neighbors;
            StringBuilder sb = new StringBuilder();
            sb.Append(GraphNode.Key + "-> ");
            foreach (GraphNode neighbor in neighbors) {
                sb.Append(neighbor.identifier + " ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}