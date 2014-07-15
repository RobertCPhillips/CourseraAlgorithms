using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GraphAlgorithms
{
    public class HammingDistanceClustering
    {
        private readonly string _file;
        private readonly char[] _seperator = { ' ', '\t' };

        public HammingDistanceClustering(string file)
        {
            _file = file;
        }

        public int Calculate()
        {
            var lines = File.ReadAllLines(_file).Skip(1).ToArray(); //skip comment line
            var countData = lines[0].Split(_seperator, StringSplitOptions.RemoveEmptyEntries);
            var nodeCount = Int32.Parse(countData[0]);
            var edgeBitSize = Int32.Parse(countData[1]);

            var possibleNumberOfNodes = (int) Math.Pow(2, edgeBitSize);
            var possibleNodes = new Node[possibleNumberOfNodes];
            var possibleClusters = new HashSet<int>[possibleNumberOfNodes];

            var nodes = new List<Node>(nodeCount);

            foreach (var line in lines.Skip(1)) //skip size line
            {
                var bits = line.Split(_seperator, StringSplitOptions.RemoveEmptyEntries).Reverse()
                    .Select(l => l == "1").ToArray();

                var bitArray = new BitArray(bits);
                var number = new int[1];
                bitArray.CopyTo(number, 0);
                var nodeNumber = number[0];
                var node = new Node(nodeNumber);

                //ignore duplicates
                if (possibleNodes[nodeNumber] == null)
                {
                    nodes.Add(node);
                    possibleNodes[nodeNumber] = node;
                }
            }

            var possibleNeighbors = GetPossibleNeighbors(edgeBitSize);
            var clusterCount = 0;

            foreach (var node in nodes)
            {
                foreach (var possibleNeighbor in possibleNeighbors)
                {
                    var index = node.Label ^ possibleNeighbor;
                    var otherNode = possibleNodes[index];
                    if (otherNode == null) continue;

                    //new cluster
                    if (node.ClusterId == 0 && otherNode.ClusterId == 0)
                    {
                        node.ClusterId = node.Label;
                        otherNode.ClusterId = node.ClusterId;
                        possibleClusters[node.ClusterId] = new HashSet<int>(new[]{node.Label, otherNode.Label});
                        ++clusterCount;
                    }
                    //node merges into other's cluster
                    else if (node.ClusterId == 0)
                    {
                        node.ClusterId = otherNode.ClusterId;
                        possibleClusters[otherNode.ClusterId].Add(node.Label);
                    }
                    //other merges into node's cluster
                    else if (otherNode.ClusterId == 0)
                    {
                        otherNode.ClusterId = node.ClusterId;
                        possibleClusters[node.ClusterId].Add(otherNode.Label);
                    }
                    //merging clusters
                    else if (node.ClusterId != otherNode.ClusterId)
                    {
                        //get those who have other as leader, and set those to have node as leader
                        var otherClusterId = otherNode.ClusterId;

                        possibleClusters[otherClusterId]
                            .ToList()
                            .ForEach(n =>
                            {
                                possibleNodes[n].ClusterId = node.ClusterId;
                                possibleClusters[node.ClusterId].Add(n);
                            });

                        possibleClusters[otherClusterId] = null;

                        --clusterCount;
                    }
                }

                //no neighbor
                if (node.ClusterId == 0)
                {
                    node.ClusterId = node.Label;
                    possibleClusters[node.ClusterId] = new HashSet<int>(new[] { node.Label });
                    ++clusterCount;
                }
            }

            return clusterCount;
        }

        static int[] GetPossibleNeighbors(int size)
        {
            var result = new List<int> { 1 };

            for (var i = 1; i < size; i++)
            {
                var bits1 = new BitArray(size);
                bits1.Set(i, true);

                var theOneBitInt = new int[1];
                bits1.CopyTo(theOneBitInt, 0);
                result.Add(theOneBitInt[0]);

                for (var j = 0; j < i; j++)
                {
                    var bits2 = new BitArray(size);
                    bits2.Set(i, true);
                    bits2.Set(j, true);

                    var theTwoBitInt = new int[1];
                    bits2.CopyTo(theTwoBitInt, 0);
                    result.Add(theTwoBitInt[0]);
                }
            }

            return result.ToArray();
        }
    }
}