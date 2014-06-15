namespace GraphAlgorithms
{
    // compute the shortest-path distances between starting node and every other vertex of the graph. 
    // if there is no path between a vertex and vertex 1, the shortest-path distance should be 1000000. 
    public class Dijkstra
    {
        private const int NoPathDistance = 1000000;

        private readonly IGraph _graph;

        public Dijkstra(IGraph graph)
        {
            _graph = graph;
        }

        public Node[] Execute(Node startingNode)
        {
            var nodeCount = _graph.Nodes.Count;

            var a = new Node[nodeCount + 1]; //+1 since nodes are 1 based

            startingNode.Distance = 0;
            a[startingNode.Label] = startingNode;

            var x = 1;

            while (x < nodeCount)
            {
                //among all edges with left in x and right not in x (or right in x and left not in x)
                //pick the one that minimizes a[left|right] + (left|right).Distance

                var distance = int.MaxValue;
                Node n = null;

                foreach (var e in _graph.Edges)
                {
                    //left is in x
                    if (a[e.Left.Label] != null && a[e.Right.Label] == null)
                    {
                        var tempDistance = a[e.Left.Label].Distance + e.Weight;
                        if (tempDistance < distance)
                        {
                            distance = tempDistance;
                            n = e.Right;
                        }
                    }
                    //right is in x
                    else if (a[e.Right.Label] != null && a[e.Left.Label] == null)
                    {
                        var tempDistance = a[e.Right.Label].Distance + e.Weight;
                        if (tempDistance < distance)
                        {
                            distance = tempDistance;
                            n = e.Left;
                        }
                    }
                }

                n.Distance = distance;
                a[n.Label] = n;

                ++x;
            }

            return a;
        }
    }
}