using System.Collections.Generic;
using System.Linq;

namespace GraphAlgorithms
{
    public class Scc
    {
        private readonly IGraph _graph;

        private int _finishTimeCounter;
        
        private readonly List<int> _sccSizeList;
        private int _sccSizeCounter;

        public Scc(IGraph graph)
        {
            _graph = graph;
            _finishTimeCounter = 0;
            _sccSizeList = new List<int>();
        }

        public List<int> Execute()
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

            foreach (var node in bySort)
            {
                if (node.Visited) continue;
                _sccSizeCounter = 0;

                Dfs(node);
                
                _sccSizeList.Add(_sccSizeCounter);
            }
            return _sccSizeList;
        }

        private void Dfs(Node startingNode)
        {
            _sccSizeCounter++;
            startingNode.Visited = true;

            var neighbors = _graph.SelectNotVisitedNodes(startingNode);

            foreach (var neighbor in neighbors)
            {
                if (!neighbor.Visited) Dfs(neighbor);
            }

            startingNode.Sort = _finishTimeCounter++;
        }
    }
}