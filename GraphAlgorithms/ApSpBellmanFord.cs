using System.Linq;

namespace GraphAlgorithms
{
    public class ApSpBellmanFord
    {
        private readonly IGraph _graph;

        public ApSpBellmanFord(IGraph graph)
        {
            _graph = graph;
        }

        public int Execute(int startLabel)
        {
            var n = _graph.Nodes.Count;

            int[] previousColumn = null;
            var column = Enumerable.Repeat(int.MaxValue, n + 1).ToArray(); //+1 for 1 based indexing
            column[startLabel] = 0;

            for (var i = 1; i <= n; i++)
            {
                var temp = new int[n + 1];

                foreach (var node in _graph.Nodes)
                {
                    temp[node.Label] = Min(column, node);
                }

                previousColumn = column;
                column = temp;
            }

            for (var i = 1; i <= n; i++)
            {
                if (column[i] != previousColumn[i]) return int.MinValue;
            }

            return column.Where(i => i != 0).Min();
        }

        private static int Min(int[] previousColumn, Node node)
        {
            var min = previousColumn[node.Label];

            var incomingEdges = node.IncomingEdges;

            foreach (var incomingEdge in incomingEdges)
            {
                var prefixWeight = previousColumn[incomingEdge.Left.Label];
                if (prefixWeight == int.MaxValue) continue;

                var newCost = prefixWeight + incomingEdge.Weight;
                if (newCost < min) min = newCost;
            }

            return min;
        }
    }
}