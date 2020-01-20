using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Graph
    {
        public List<GraphNode> Nodes;

        public Graph()
        {
            Nodes = new List<GraphNode>();
        }
    }

    public class GraphNode
    {
        public char Value { get; set; }
        public List<GraphNode> Neighbors { get; set; }
    }
}
