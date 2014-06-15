using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GraphAlgorithms
{
    public class DijkstraGraphBuilder : IGraphBuilder
    {
        private readonly string _file;
        private readonly char[] _seperator = { ' ','\t' };
        private readonly char[] _edgeSeperator = {','};

        public DijkstraGraphBuilder(string file)
        {
            _file = file;
        }

        public IGraph Build()
        {
            var lines = File.ReadAllLines(_file);

            var nodes = new Node[lines.Length + 1]; //since nodes are 1 based
            var edges = new List<Edge>();
            var edgeId = 0;

            foreach (var line in lines)
            {
                var dataitems = line.Split(_seperator, StringSplitOptions.RemoveEmptyEntries);
                
                var label = Int32.Parse(dataitems[0]);

                var left = nodes[label];
                if (left == null)
                {
                    left = new Node(label);
                    nodes[label] = left;
                }

                foreach (var item in dataitems.Skip(1))
                {
                    var values = item.Split(_edgeSeperator);

                    var itemLabel = Int32.Parse(values[0]);
                    var itemWeight = Int32.Parse(values[1]);

                    var right = nodes[itemLabel];
                    if (right == null)
                    {
                        right = new Node(itemLabel);
                        nodes[itemLabel] = right;
                    }

                    //undirected, no paralle, so no need to add edge if left > right as it should already be added
                    if (left.Label > right.Label) continue;

                    var edge = new Edge(++edgeId, left, right, EdgeDirection.None, itemWeight);
                    edges.Add(edge);
                }
            }

            var finalNodes = nodes.Where(n => n != null).ToList();
            return new Graph(finalNodes, edges);
        }
    }
}