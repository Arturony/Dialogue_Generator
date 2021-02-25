using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialogue_Generator
{
    class Node
    {
        public string key;

        public string value;

        public bool reviwable;

        public bool visited;

        public List<string> restrictions;

        public Dictionary<string, Edge> edges;

        public Node(string key, string value, bool rewview)
        {
            this.key = key;
            this.value = value;
            this.reviwable = rewview;
            restrictions = new List<string>();
            edges = new Dictionary<string, Edge>();
        }

        public Edge getNode(string key)
        {
            return edges[key];
        }

        public List<Edge> getAllEdges()
        {
            List<Edge> edge = new List<Edge>();
            foreach (Edge e in edges.Values)
            {
                edge.Add(e);
            }
            return edge;
        }

        public void AddEdge(Edge e)
        {
            edges.Add(e.key, e);
        }

        public void RemoveEdge(string key)
        {
            edges.Remove(key);
        }

        
    }
}
