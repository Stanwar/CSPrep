// Various representations for graphs
using System;
using System.Collections.Generic;

internal class Graph{
    public List<int> rows;
    public List<int> columns;

    // Constructors
    public Graph() {
        // Initialize graph to 10 r/c
        this.rows = new List<int>();
        this.columns = new List<int>();
    }

    public Graph(int v){
        this.rows = new List<int>();
        this.columns = new List<int>();
        this.rows.Capacity = v;
        this.columns.Capacity = v;
    }

    public Graph(int r, int c) {
        this.rows = new List<int>();
        this.columns = new List<int>();
        rows.Capacity = r;
        columns.Capacity = c;
    }

    public void AddGraph(){

    }
}