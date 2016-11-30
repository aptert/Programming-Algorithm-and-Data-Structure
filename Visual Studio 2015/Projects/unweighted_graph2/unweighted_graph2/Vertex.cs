using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unweighted_graph
{
    class Vertex
    {
        private int label;
        private List<Vertex> edge;

        //Constructor
        public Vertex(int label)
        {
            this.label = label;
            edge = new List<Vertex>();
        }

        public void setLabel(int label)
        {
            this.label = label;
        }

        public int getLabel()
        { 
            return label;
        }

        public List<Vertex> getEdge()
        {
            return edge;
        }
        public void Link(Vertex v)
        {
            if (!edge.Contains(v))
            {
                edge.Add(v);
            }
            else
            {
                Console.Write("Link has already been set");
            }

        }

        public void toString()
        {
            Console.WriteLine("label: " + label);
            Console.WriteLine("edge: " + edge.ToString());
        }

        public void breakLink(Vertex v1, Vertex v2)
        {

        }

    }
}
