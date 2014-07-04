using System.Collections.Generic;
using System.Linq;

namespace GraphAlgorithms
{
    public class Prim
    {
        private readonly IGraph _graph;

        public Prim(IGraph graph)
        {
            _graph = graph;
        }

        public long Execute()
        {
            var spannedEdges = new List<Edge>();

            var spannedNodes = new Node[_graph.Nodes.Count + 1]; //+1 since node Ids are 1-based
            spannedNodes[_graph.Nodes[0].Label] = _graph.Nodes[0];
            var x = 1;

            while (x <= _graph.Nodes.Count)
            {
                Edge cheapest = null;

                foreach (var edge in _graph.Edges)
                {
                    var leftId = edge.Left.Label;
                    var rightId = edge.Right.Label;

                    //both included
                    if (spannedNodes[leftId] != null && spannedNodes[rightId] != null) continue;
                    //neither included
                    if (spannedNodes[leftId] == null && spannedNodes[rightId] == null) continue;

                    if (cheapest == null || edge.Weight < cheapest.Weight) cheapest = edge;
                }

                if (cheapest != null)
                {
                    spannedEdges.Add(cheapest);
                    spannedNodes[cheapest.Left.Label] = cheapest.Left;
                    spannedNodes[cheapest.Right.Label] = cheapest.Right;
                }
                ++x;
            }

            return spannedEdges.Sum(e => (long) e.Weight);
        }
    }
}