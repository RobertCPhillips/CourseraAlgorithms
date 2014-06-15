using System.Collections.Generic;
using System.Linq;

namespace GraphAlgorithms
{
    public class Dfs
    {
        private readonly IGraph _graph;
        //private readonly Stack<Node> _visited;

        private int _sortCounter;
 
        public Dfs(IGraph graph)
        {
            _graph = graph;
            //_visited = new Stack<Node>();
            _sortCounter = _graph.Nodes.Count;
        }

        public void Execute(Node startingNode)
        {
            startingNode.Visited = true;

            var neighbors = _graph.SelectNotVisitedNodes(startingNode);

            foreach (var neighbor in neighbors)
            {
                if(!neighbor.Visited) Execute(neighbor);
            }

            startingNode.Sort = _sortCounter--;
        }

        //public void Execute(Node startingNode)
        //{
        //    _visited.Push(startingNode);
        //    var pathDebug = string.Empty;

        //    while (_visited.Any())
        //    {
        //        var node = _visited.Pop();
        //        node.Visited = true;
        //        pathDebug = pathDebug + node.Label + " -> ";

        //        var neighbors = _graph.SelectNotVisitedNodes(node);

        //        if (!neighbors.Any())
        //        {
        //            node.Sort = _sortCounter--;
        //            continue;
        //        }
        //        _visited.Push(node);
        //        foreach (var neighbor in neighbors)
        //        {
        //            _visited.Push(neighbor);
        //        }
        //    }
        //}
    }
}