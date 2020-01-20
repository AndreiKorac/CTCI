using DSA;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCISolutions
{
    class Chapter4
    {
        public char[] BuildOrder(char[] projects, (char, char)[] dependencies)
        {
           
            return new char[] { 'a' };
            //each project is a node and each dependency tuple is an edge between two
            //construct graph out of these nodes and edges
            //for each node in the graph
            //visit each of its unvisited neighbours
            //if current node has no more unvisited neighbors, push it to a stack
            //in the end the stack will contain the ordered dependencies of the project (topologically sorted graph)
            
        }
    }
}
