using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unweighted_graph
{
    class Program
    {

        static void DFS_iterative(Graph g, Vertex v)
        {
            Stack<Vertex> stack = new Stack<Vertex>();
            List<Vertex> visited = new List<Vertex>();
            stack.Push(v);
            while (stack.Peek() != null)
            {
                Vertex u = stack.Pop();
                if (!visited.Contains(u))
                {
                    visited.Add(u);
                    for ()
                }
            }
        }
        static void Main(string[] args)
        {
            Graph g = new Graph();
            Vertex v1 = new Vertex(1);
            Vertex v2 = new Vertex(2);
            Vertex v3 = new Vertex(3);
            Vertex v4 = new Vertex(4);
            Vertex v5 = new Vertex(5);

            g.addVertex(v1);
            g.addVertex(v2);
            g.addVertex(v3);
            g.addVertex(v4);
            g.addVertex(v5);

            g.addEdge(v1, v2);
            g.addEdge(v2, v4);
            g.addEdge(v3, v4);
            g.addEdge(v4, v5);
            g.addEdge(v3, v5);
            Console.ReadKey();

        }
    }
}
