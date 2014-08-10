using System.Collections.Generic;
using System.Linq;

namespace GraphAlgorithms
{
    public class TwoSatScc
    {
        private readonly IGraph _graph;

        private int _finishTimeCounter;
        private int _sccIndexer;
        private readonly List<HashSet<int>> _sccNodes;

        public TwoSatScc(IGraph graph)
        {
            _graph = graph;

            _sccNodes = new List<HashSet<int>>();
        }

        public bool Execute()
        {
            _graph.ReverseEdges();

            foreach (var node in _graph.Nodes)
            {
                if (node.Visited == false) Dfs(node);
            }

            _graph.ReverseEdges();

            //todo...
            var bySort = _graph.Nodes.OrderByDescending(n => n.Sort).ToList();
            bySort.ForEach(n => n.Visited = false);

            _sccIndexer = 0;

            foreach (var node in bySort)
            {
                if (node.Visited) continue;

                _sccNodes.Add(new HashSet<int>());

                Dfs(node, true);

                ++_sccIndexer;
            }

            var result = _sccNodes.All(Assignable);
            return result;
        }

        private static bool Assignable(HashSet<int> arg)
        {
            return arg.All(a => !arg.Contains(-a));
        }

        private void Dfs(Node startingNode, bool accumulate = false)
        {
            startingNode.Visited = true;

            var neighbors = _graph.SelectNotVisitedNodes(startingNode);
            if (accumulate) _sccNodes[_sccIndexer].UnionWith(neighbors.Select(n => n.Label));

            foreach (var neighbor in neighbors)
            {
                if (!neighbor.Visited) Dfs(neighbor, accumulate);
            }

            startingNode.Sort = _finishTimeCounter++;
        }
    }
}