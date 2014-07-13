using System.Collections.Generic;
using System.Linq;

namespace GraphAlgorithms
{
    public class DistanceClustering
    {
        private readonly IGraph _graph;

        public DistanceClustering(IGraph graph)
        {
            _graph = graph;
        }

        public int Execute(int k)
        {
            var clusterCount = 0;
            var nodesNotAssigned = _graph.Nodes.Count;

            foreach (var edge in _graph.Edges)
            {
                //do i need to create more clusters?
                if (nodesNotAssigned <= (k - clusterCount))
                {
                    if (edge.Right.ClusterId == 0)
                    {
                        edge.Right.ClusterId = edge.Right.Label;
                        ++clusterCount;
                        nodesNotAssigned--;
                    }
                    if (edge.Left.ClusterId == 0)
                    {
                        edge.Left.ClusterId = edge.Left.Label;
                        ++clusterCount;
                        nodesNotAssigned--;
                    }
                    if (nodesNotAssigned == 0) break;
                    continue;
                }

                //these form a new cluster
                if (edge.Left.ClusterId == 0 && edge.Right.ClusterId == 0)
                {
                    edge.Left.ClusterId = edge.Left.Label;
                    edge.Right.ClusterId = edge.Left.ClusterId;
                    ++clusterCount;
                    nodesNotAssigned -= 2;
                }
                //adding left to right's cluster
                else if (edge.Left.ClusterId == 0)
                {
                    edge.Left.ClusterId = edge.Right.ClusterId;
                    nodesNotAssigned--;
                }
                //adding right to left's cluster
                else if (edge.Right.ClusterId == 0)
                {
                    edge.Right.ClusterId = edge.Left.ClusterId;
                    nodesNotAssigned--;
                }
                //merging clusters, this reduces cluster count
                else if (edge.Left.ClusterId != edge.Right.ClusterId)
                {
                    //all in left's cluster changed to right's cluster
                    var leftClusterId = edge.Left.ClusterId;
                    _graph.Nodes.Where(n => n.ClusterId == leftClusterId)
                        .ToList()
                        .ForEach(n => n.ClusterId = edge.Right.ClusterId);
                    --clusterCount;
                }
            }

            return _graph.Edges.Where(e => e.Left.ClusterId != e.Right.ClusterId).Min(e => e.Weight);
        }
    }
}