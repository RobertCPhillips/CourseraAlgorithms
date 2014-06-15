using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GraphAlgorithms;

namespace GraphSccHw
{
    class Program
    {
        const string File = "directed_graph_hw.txt";

        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            //ManualBuild();
            //Builder();
            var t = new Thread(Scc, 1024*1024*100);
            t.Start();
            //Scc();
            t.Join();
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        static void Builder()
        {
            var builder = new HwDirectedGraphBuilder2(File);
            var graph = builder.Build();

            Console.WriteLine(graph.Edges.Count);
            Console.WriteLine(graph.Nodes.Count);
        }

        static void Scc()
        {
            var builder = new HwDirectedGraphBuilder2(File);
            var graph = builder.Build();

            var scc = new Scc(graph);
            var result = scc.Execute();

            var result2 = result.OrderByDescending(x => x).Take(10);
            var result3 = string.Join(",", result2);
            Console.WriteLine(result3);
        }

        static void ManualBuild()
        {
            var seperator = new[] { ' ', '\t' };
            var lines = System.IO.File.ReadAllLines(File);

            var nodes = new TheNode[lines.Length];
            var edges = new List<TheEdge>(lines.Length);

            foreach (var line in lines)
            {
                var dataitems = line.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                var left = Int32.Parse(dataitems[0]);
                var right = Int32.Parse(dataitems[1]);

                if (nodes[left] == null) nodes[left] = new TheNode(left);
                if (nodes[right] == null) nodes[right] = new TheNode(right);

                var edge = new TheEdge(nodes[left], nodes[right]);
                edges.Add(edge);
            }
            Console.WriteLine(edges.Count);
            var finalNodes = new List<TheNode>(nodes.Where(n => n != null));
            Console.WriteLine(finalNodes.Count);
        }
    }

    public class TheNode
    {
        public TheNode(int label)
        {
            Label = label;
        }

        public int Label { get; private set; }
    }

    public class TheEdge
    {
        public TheEdge(TheNode left, TheNode right)
        {
            Right = right;
            Left = left;
        }

        public TheNode Left { get; private set; }
        public TheNode Right { get; private set; }
    }
}
