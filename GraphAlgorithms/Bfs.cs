using System.Collections.Generic;
using System.Linq;

namespace GraphAlgorithms
{
    public class Bfs
    {
        private readonly IGraph _graph;
        private readonly Queue<Node> _visited;
 
        public Bfs(IGraph graph)
        {
            _graph = graph;
            _visited = new Queue<Node>();
        }

        public void Execute(Node startingNode)
        {
            startingNode.Visited = true;
            _visited.Enqueue(startingNode);

            while (_visited.Any())
            {
                var node = _visited.Dequeue();

                var neighbors = _graph.SelectNotVisitedNodes(node);

                foreach (var neighbor in neighbors)
                {
                    neighbor.Visited = true;
                    neighbor.Distance = node.Distance + 1;
                    _visited.Enqueue(neighbor);
                }
            }
        }
    }
}