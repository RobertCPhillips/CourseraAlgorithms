using System.Collections.Generic;
using System.Linq;

namespace GraphAlgorithms
{
    public class Graph : IGraph
    {
        public Graph(IList<Node> nodes, IList<Edge> edges)
        {
            Nodes = nodes;
            Edges = edges;
        }

        public IList<Node> Nodes { get; private set; }
        public IList<Edge> Edges { get; private set; }

        public void Contract(Edge edge)
        {
            var toRemove =
                Edges.Where(
                    e =>
                    e == edge || (e.Left == edge.Left && e.Right == edge.Right) ||
                    (e.Left == edge.Right && e.Right == edge.Left)).ToArray();

            foreach (var item in toRemove) Edges.Remove(item);

            Nodes.Remove(edge.Right);

            var toMove = Edges.Where(e => e.Left == edge.Right || e.Right == edge.Right);
            foreach (var item in toMove)
            {
                if (item.Right == edge.Right) item.Right = edge.Left;
                else item.Left = edge.Left;
            }
        }

        public IList<Node> SelectNotVisitedNodes(Node startingNode)
        {
            var neighbors = Edges
                      .Where(e => (e.Left == startingNode && (e.Direction == EdgeDirection.None || e.Direction == EdgeDirection.LeftToRight)) || 
                                  (e.Right == startingNode && (e.Direction == EdgeDirection.None || e.Direction == EdgeDirection.RightToLeft)))
                      .Select(n => n.Left == startingNode ? n.Right : n.Left)
                      .Where(n => !n.Visited);

            return neighbors.ToList();
        }

        public void ReverseEdges()
        {
            foreach (var edge in Edges)
            {
                edge.Direction = edge.Direction == EdgeDirection.LeftToRight ? 
                    EdgeDirection.RightToLeft : 
                    EdgeDirection.LeftToRight;
            }
        }
    }
}