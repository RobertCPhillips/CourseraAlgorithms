namespace GraphAlgorithms
{
    public class ApSpBellmanFordAllVertices
    {
        private readonly IGraph _graph;
        private readonly ApSpBellmanFord _bf;

        public ApSpBellmanFordAllVertices(IGraph graph)
        {
            _graph = graph;
            _bf = new ApSpBellmanFord(graph);
        }

        public int Execute()
        {
            var min = int.MaxValue;

            foreach (var node in _graph.Nodes)
            {
                var currentMin = _bf.Execute(node.Label);

                if (currentMin < min) min = currentMin;
                if (min == int.MinValue) break;
            }

            return min;
        }
    }
}