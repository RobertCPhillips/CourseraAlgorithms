using System.Collections.Generic;
using System.Linq;

namespace GraphAlgorithms
{
    public class Graph2 : IGraph
    {
        private EdgeDirection _currentDirection = EdgeDirection.LeftToRight;

        public Graph2(IList<Node> nodes, IList<Edge> edges)
        {
            Edges = edges;
            Nodes = nodes;
        }

        public IList<Node> Nodes { get; private set; }
        public IList<Edge> Edges { get; private set; }

        public void Contract(Edge edge)
        {
            throw new System.NotImplementedException();
        }

        public IList<Node> SelectNotVisitedNodes(Node startingNode)
        {
            if (_currentDirection == EdgeDirection.LeftToRight)
            {
                //todo: select outgoing edges where not visited
                return startingNode.Outgoing.Where(n => !n.Visited).ToList();
            }
            //todo: select incoming edges not visited
            return startingNode.Incoming.Where(n => !n.Visited).ToList();
        }

        public void ReverseEdges()
        {
            _currentDirection = _currentDirection == EdgeDirection.LeftToRight ? 
                                    EdgeDirection.RightToLeft : 
                                    EdgeDirection.LeftToRight;
        }
    }
}