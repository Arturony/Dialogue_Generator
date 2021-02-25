using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialogue_Generator
{
    class Graph
    {
        public string name;

        public Dictionary<string, Node> nodes;

        public Node GetNode(string key)
        {
            return nodes[key];
        }

        public void AddNode(Node n)
        {
            nodes.Add(n.key, n);
        }

        public void RemoveNode(string key)
        {
            nodes.Remove(key);
        }

        public Graph(string name)
        {
            nodes = new Dictionary<string, Node>();
            this.name = name;
        }

        public List<Node> getAllNodes()
        {
            List<Node> node = new List<Node>();
            foreach (Node e in nodes.Values)
            {
                node.Add(e);
            }
            return node;
        }
    }
}
