using System;

namespace GraphAlgorithms
{
    public class GraphMinimumCut
    {
        private readonly IGraphBuilder _graphBuilder;

        public GraphMinimumCut(IGraphBuilder graphBuilder)
        {
            _graphBuilder = graphBuilder;
        }

        public int GetMinCut()
        {
            var min = int.MaxValue;

            var random = new Random();
            for (var i = 0; i < 500; i++)
            {
                var theGraph = _graphBuilder.Build();
                while (theGraph.Nodes.Count > 2)
                {
                    var edgeId = random.Next(0, theGraph.Edges.Count - 1);
                    var edge = theGraph.Edges[edgeId];
                    theGraph.Contract(edge);
                }

                if (theGraph.Edges.Count < min) min = theGraph.Edges.Count;
            }

            return min;
        }
    }
}
