using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GraphAlgorithms
{
    public class HwDirectedGraphBuilder : IGraphBuilder
    {
        private readonly string _file;
        private readonly char[] _seperator = new[] { ' ', '\t' };

        public HwDirectedGraphBuilder(string file)
        {
            _file = file;
        }

        public IGraph Build()
        {
            var lines = File.ReadAllLines(_file);

            var nodes = new Node[lines.Length+1]; //+1 since nodes are 1 based
            var edges = new List<Edge>(lines.Length);
            var edgeId = 0;

            foreach (var line in lines)
            {
                var dataitems = line.Split(_seperator, StringSplitOptions.RemoveEmptyEntries);
                var left = Int32.Parse(dataitems[0]);
                var right = Int32.Parse(dataitems[1]);

                if (nodes[left] == null) nodes[left] = new Node(left);
                if (nodes[right] == null) nodes[right] = new Node(right);

                var edge = new Edge(++edgeId, nodes[left], nodes[right], EdgeDirection.LeftToRight);
                edges.Add(edge);
            }

            var finalNodes = new List<Node>(nodes.Where(n => n != null));
            return new Graph(finalNodes, edges);
        }
    }
}