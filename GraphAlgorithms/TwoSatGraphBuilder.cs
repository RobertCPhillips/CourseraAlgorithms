using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GraphAlgorithms
{
    public class TwoSatGraphBuilder : IGraphBuilder
    {
        private readonly string _file;
        private readonly char[] _seperator = { ' ', '\t' };

        public TwoSatGraphBuilder(string file)
        {
            _file = file;
        }

        public IGraph Build()
        {
            var lines = File.ReadAllLines(_file).Skip(1).ToArray(); //skip comment line
            var countData = lines[0].Split(_seperator, StringSplitOptions.RemoveEmptyEntries);
            var size = Int32.Parse(countData[0]);

            var nodes = new Node[2*size + 1]; //+1 for 1-based index, *2 for neg values

            var edges = new List<Edge>(2*size);
            var edgeId = 0;

            foreach (var line in lines.Skip(1)) //skip size line
            {
                var data = line.Split(_seperator, StringSplitOptions.RemoveEmptyEntries);
                var leftNodeId = Int32.Parse(data[0]);
                var rightNodeId = Int32.Parse(data[1]);

                var leftNodeId1 = -leftNodeId;
                var rightNodeId1 = rightNodeId;

                var leftNodeId2 = -rightNodeId;
                var rightNodeId2 = leftNodeId;

                ////////////////////////////////////
                //left node 1
                var leftIndex1 = (leftNodeId1 < 0) ? (size - leftNodeId1) : leftNodeId1;

                var leftNode1 = nodes[leftIndex1];
                if (leftNode1 == null)
                {
                    leftNode1 = new Node(leftNodeId1);
                    nodes[leftIndex1] = leftNode1;
                }

                ////////////////////////////////////
                //left node 2
                var leftIndex2 = (leftNodeId2 < 0) ? (size - leftNodeId2) : leftNodeId2;

                var leftNode2 = nodes[leftIndex2];
                if (leftNode2 == null)
                {
                    leftNode2 = new Node(leftNodeId2);
                    nodes[leftIndex2] = leftNode2;
                }

                ////////////////////////////////////
                //right node 1
                var rightIndex1 = (rightNodeId1 < 0) ? (size - rightNodeId1) : rightNodeId1;

                var rightNode1 = nodes[rightIndex1];
                if (rightNode1 == null)
                {
                    rightNode1 = new Node(rightNodeId1);
                    nodes[rightIndex1] = rightNode1;
                }

                ////////////////////////////////////
                //right node 1
                var rightIndex2 = (rightNodeId2 < 0) ? (size - rightNodeId2) : rightNodeId2;

                var rightNode2 = nodes[rightIndex2];
                if (rightNode2 == null)
                {
                    rightNode2 = new Node(rightNodeId2);
                    nodes[rightIndex2] = rightNode2;
                }

                leftNode1.Outgoing.Add(rightNode1);
                rightNode1.Incoming.Add(leftNode1);
                leftNode2.Outgoing.Add(rightNode2);
                rightNode2.Incoming.Add(leftNode2);

                var edge1 = new Edge(++edgeId, leftNode1, rightNode1, EdgeDirection.LeftToRight);
                var edge2 = new Edge(++edgeId, leftNode2, rightNode2, EdgeDirection.LeftToRight);
                edges.Add(edge1);
                edges.Add(edge2);
            }

            var finalNodes = nodes.Where(n => n != null).ToList();
            return new Graph2(finalNodes, edges);
        }
    }
}