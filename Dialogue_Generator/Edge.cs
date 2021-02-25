using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialogue_Generator
{
    class Edge
    {
        public string key;

        public string value;

        public string from;

        public string to;

        public Edge(string key, string value, string from, string to)
        {
            this.key = key;
            this.value = value;
            this.from = from;
            this.to = to;
        }
    }
}
