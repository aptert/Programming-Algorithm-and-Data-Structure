
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unweighted_graph
{
    class Graph
    {
        private List<Vertex> list;

        public Graph()
        {
            this.list = new List<Vertex>();
        }

        public void addVertex(Vertex v)
        {
            if (this.list.Contains(v))
            {
                Console.Write("Vertex already exists");
            }
            else {
                this.list.Add(v);
            }
        }

        public void removeVertex(Vertex v)
        {
            if (!this.list.Contains(v))
            {
                Console.Write("Vertex does not exists");
            }
            else
            {
                this.list.Remove(v);
            }
        }

        public void addEdge(Vertex v1, Vertex v2)
        {
            v1.Link(v2);
            v2.Link(v1);
        }

       
    }
}
