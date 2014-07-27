using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GraphAlgorithms
{
    public class ApSpGraphBuilder : IGraphBuilder
    {
        private readonly string _file;
        private readonly char[] _seperator = { ' ', '\t' };

        public ApSpGraphBuilder(string file)
        {
            _file = file;
        }

        public IGraph Build()
        {
            var lines = File.ReadAllLines(_file).Skip(1).ToArray(); //skip comment line
            var countData = lines[0].Split(_seperator, StringSplitOptions.RemoveEmptyEntries);
            var verticeCount = Int32.Parse(countData[0]);
            var edgeCount = Int32.Parse(countData[1]);

            var nodes = new Node[verticeCount + 1]; //since nodes are 1 based
            var edges = new List<Edge>(edgeCount);
            var edgeId = 0;

            foreach (var line in lines.Skip(1)) //skip size line
            {
                var data = line.Split(_seperator, StringSplitOptions.RemoveEmptyEntries);
                var tailLabel = Int32.Parse(data[0]);
                var headLabel = Int32.Parse(data[1]);
                var edgeCost = Int32.Parse(data[2]);

                var tail = nodes[tailLabel];
                if (tail == null)
                {
                    tail = new Node(tailLabel);
                    nodes[tailLabel] = tail;
                }

                var head = nodes[headLabel];
                if (head == null)
                {
                    head = new Node(headLabel);
                    nodes[headLabel] = head;
                }

                var edge = new Edge(++edgeId, tail, head, EdgeDirection.LeftToRight, edgeCost);
                edges.Add(edge);

                nodes[headLabel].IncomingEdges.Add(edge);
            }

            var finalNodes = nodes.Skip(1).ToList();
            return new Graph(finalNodes, edges);
        }
    }
}
