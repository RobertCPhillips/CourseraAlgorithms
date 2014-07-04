using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GraphAlgorithms
{
    public class PrimGraphBuilder : IGraphBuilder
    {
        private readonly string _file;
        private readonly char[] _seperator = { ' ', '\t' };

        public PrimGraphBuilder(string file)
        {
            _file = file;
        }

        public IGraph Build()
        {
            var lines = File.ReadAllLines(_file);
            var countData = lines[0].Split(_seperator, StringSplitOptions.RemoveEmptyEntries);
            var nodeCount = Int32.Parse(countData[0]);
            var edgeCount = Int32.Parse(countData[1]);

            var nodes = new Node[nodeCount + 1]; //+1 since nodes are 1 based
            var edges = new List<Edge>(edgeCount);
            var edgeId = 0;

            foreach (var line in lines.Skip(1))
            {
                var dataitems = line.Split(_seperator, StringSplitOptions.RemoveEmptyEntries);

                var leftNodeId = Int32.Parse(dataitems[0]);
                var rightNodeId = Int32.Parse(dataitems[1]);
                var weight = Int32.Parse(dataitems[2]);

                var leftNode = nodes[leftNodeId];
                if (leftNode == null)
                {
                    leftNode = new Node(leftNodeId);
                    nodes[leftNodeId] = leftNode;
                }

                var rightNode = nodes[rightNodeId];
                if (rightNode == null)
                {
                    rightNode = new Node(rightNodeId);
                    nodes[rightNodeId] = rightNode;
                }

                var edge = new Edge(++edgeId, leftNode, rightNode, EdgeDirection.None, weight);
                edges.Add(edge);
            }

            var finalNodes = nodes.Skip(1).ToList();
            return new Graph(finalNodes, edges);
        }
    }
}