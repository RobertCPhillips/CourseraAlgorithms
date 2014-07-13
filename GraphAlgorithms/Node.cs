using System.Collections.Generic;

namespace GraphAlgorithms
{
    public class Node
    {
        public Node(int label)
        {
            Label = label;
            Incoming = new List<Node>();
            Outgoing = new List<Node>();
        }

        public int Label { get; private set; }
        public bool Visited { get; set; }
        public int Distance { get; set; }
        public int Sort { get; set; }
        public int ClusterId { get; set; }

        public List<Node> Incoming { get; private set; }
        public List<Node> Outgoing { get; private set; } 

        public override string ToString()
        {
            return "Node " + Label;
        }
    }
}