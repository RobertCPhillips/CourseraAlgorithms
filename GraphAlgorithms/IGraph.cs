using System.Collections.Generic;

namespace GraphAlgorithms
{
    public interface IGraph
    {
        IList<Node> Nodes { get; }
        IList<Edge> Edges { get; }

        void Contract(Edge edge);
        IList<Node> SelectNotVisitedNodes(Node startingNode);
        void ReverseEdges();
    }
}