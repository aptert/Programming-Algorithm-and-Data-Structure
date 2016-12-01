using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unweighted_graph
{
    class Program
    {

        static List<int> DFS_iterative(Graph g, Vertex v)
        {
            Stack<int> stack = new Stack<int>();
            List<int> visited = new List<int>();
            stack.Push(v.getLabel());
            while (stack.Count != 0) 
            {
                int u = stack.Pop();
                if (!visited.Contains(u))
                {
                    visited.Add(u);
                    foreach(Vertex w in v.getEdge())
                    {
                        stack.Push(w.getLabel());
                    }
                }
            }
            return visited;
        }

        static List<int> BFS_iterative(Graph g, Vertex v)
        {
            Queue<int> queue = new Queue<int>();
            List<int> visited = new List<int>();
            queue.Enqueue(v.getLabel());
            while(queue.Count != 0)
            {
                int u = queue.Dequeue();
                if (!visited.Contains(u))
                {
                    visited.Add(u);
                    foreach(Vertex w in v.getEdge())
                    {
                        queue.Enqueue(w.getLabel());
                    }
                }
            }
            return visited;
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

            BFS_iterative(g, v1).ForEach(Console.WriteLine);
            Console.ReadKey();

        }
    }
}
