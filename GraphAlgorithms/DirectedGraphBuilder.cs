using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GraphAlgorithms
{
    public class DirectedGraphBuilder : IGraphBuilder
    {
        private readonly string _file;
        private readonly char[] _seperator = new[] { ' ', '\t' };

        public DirectedGraphBuilder(string file)
        {
            _file = file;
        }

        public IGraph Build()
        {
            var nodes = new List<Node>();
            var edges = new List<Edge>();
            var edgeId = 0;

            var lines = File.ReadAllLines(_file);
            foreach (var line in lines)
            {
                var dataitems = line.Split(_seperator, StringSplitOptions.RemoveEmptyEntries);

                var label = Int32.Parse(dataitems[0]);

                var left = nodes.SingleOrDefault(i => i.Label == label);
                if (left == null)
                {
                    left = new Node(label);
                    nodes.Add(left);
                }

                foreach (var item in dataitems.Skip(1))
                {
                    var itemLabel = Int32.Parse(item);
                    var right = nodes.SingleOrDefault(i => i.Label == itemLabel);
                    if (right == null)
                    {
                        right = new Node(itemLabel);
                        nodes.Add(right);
                    }

                    var edge = new Edge(++edgeId, left, right, EdgeDirection.LeftToRight);
                    edges.Add(edge);
                }
            }

            return new Graph(nodes, edges);
        }
    }
}