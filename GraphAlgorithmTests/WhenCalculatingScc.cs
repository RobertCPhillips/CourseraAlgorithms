using System.Linq;
using GraphAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace GraphAlgorithmTests
{
    public class WhenCalculatingScc
    {
        [TestClass]
        public class WhenUsingDirectedGraphLecture01
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Scc _scc;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new HwDirectedGraphBuilder2("directed_graph_lecture_01.txt");
                _graph = _graphBuilder.Build();
                _scc = new Scc(_graph);
            }

            [TestMethod]
            public void Should_get_9_nodes_and_11_edges()
            {
                _graph.Nodes.Count.ShouldEqual(9);
                _graph.Edges.Count.ShouldEqual(11);
            }

            [TestMethod]
            public void Should_get_3_Sccs()
            {
                var result = _scc.Execute();
                result.Count.ShouldEqual(3);

                var result2 = result.OrderByDescending(x => x);
                string.Join(",", result2).ShouldEqual("3,3,3");
            }
        }

        [TestClass]
        public class WhenUsingDirectedGraph03
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Scc _scc;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new HwDirectedGraphBuilder2("directed_graph_03.txt");
                _graph = _graphBuilder.Build();
                _scc = new Scc(_graph);
            }

            [TestMethod]
            public void Should_get_9_nodes_and_11_edges()
            {
                _graph.Nodes.Count.ShouldEqual(9);
                _graph.Edges.Count.ShouldEqual(11);
            }

            [TestMethod]
            public void Should_get_3_Sccs()
            {
                var result = _scc.Execute();
                result.Count.ShouldEqual(3);

                var result2 = result.OrderByDescending(x => x);
                string.Join(",", result2).ShouldEqual("3,3,3");
            }
        }

        [TestClass]
        public class WhenUsingDirectedGraph04
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Scc _scc;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new HwDirectedGraphBuilder2("directed_graph_04.txt");
                _graph = _graphBuilder.Build();
                _scc = new Scc(_graph);
            }

            [TestMethod]
            public void Should_get_8_nodes_and_14_edges()
            {
                _graph.Nodes.Count.ShouldEqual(8);
                _graph.Edges.Count.ShouldEqual(14);
            }

            [TestMethod]
            public void Should_get_3_Sccs()
            {
                var result = _scc.Execute();
                result.Count.ShouldEqual(3);

                var result2 = result.OrderByDescending(x => x);
                string.Join(",", result2).ShouldEqual("3,3,2");
            }
        }

        [TestClass]
        public class WhenUsingDirectedGraph05
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Scc _scc;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new HwDirectedGraphBuilder2("directed_graph_05.txt");
                _graph = _graphBuilder.Build();
                _scc = new Scc(_graph);
            }

            [TestMethod]
            public void Should_get_8_nodes_and_14_edges()
            {
                _graph.Nodes.Count.ShouldEqual(8);
                _graph.Edges.Count.ShouldEqual(14);
            }

            [TestMethod]
            public void Should_get_4_Sccs()
            {
                var result = _scc.Execute();
                result.Count.ShouldEqual(4);

                var result2 = result.OrderByDescending(x => x);
                string.Join(",", result2).ShouldEqual("3,2,2,1");
            }
        }

        [TestClass]
        public class WhenUsingDirectedGraph06
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Scc _scc;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new HwDirectedGraphBuilder2("directed_graph_06.txt");
                _graph = _graphBuilder.Build();
                _scc = new Scc(_graph);
            }

            [TestMethod]
            public void Should_get_8_nodes_and_11_edges()
            {
                _graph.Nodes.Count.ShouldEqual(8);
                _graph.Edges.Count.ShouldEqual(11);
            }

            [TestMethod]
            public void Should_get_2_Sccs()
            {
                var result = _scc.Execute();
                result.Count.ShouldEqual(2);

                var result2 = result.OrderByDescending(x => x);
                string.Join(",", result2).ShouldEqual("7,1");
            }
        }

        [TestClass]
        public class WhenUsingDirectedGraph07
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Scc _scc;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new HwDirectedGraphBuilder2("directed_graph_07.txt");
                _graph = _graphBuilder.Build();
                _scc = new Scc(_graph);
            }

            [TestMethod]
            public void Should_get_12_nodes_and_20_edges()
            {
                _graph.Nodes.Count.ShouldEqual(12);
                _graph.Edges.Count.ShouldEqual(20);
            }

            [TestMethod]
            public void Should_get_4_Sccs()
            {
                var result = _scc.Execute();
                result.Count.ShouldEqual(4);

                var result2 = result.OrderByDescending(x => x);
                string.Join(",", result2).ShouldEqual("6,3,2,1");
            }
        }

        [TestClass]
        public class WhenUsingDirectedGraph08
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Scc _scc;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new HwDirectedGraphBuilder2("directed_graph_08.txt");
                _graph = _graphBuilder.Build();
                _scc = new Scc(_graph);
            }

            [TestMethod]
            public void Should_get_50_nodes_and_147_edges()
            {
                _graph.Nodes.Count.ShouldEqual(50);
                _graph.Edges.Count.ShouldEqual(147);
            }

            [TestMethod]
            public void Should_get_10_Sccs()
            {
                var result = _scc.Execute();
                result.Count.ShouldEqual(10);

                var result2 = result.OrderByDescending(x => x);
                string.Join(",", result2).ShouldEqual("35,7,1,1,1,1,1,1,1,1");
            }
        }

        [TestClass]
        public class WhenUsingDirectedGraph09
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Scc _scc;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new HwDirectedGraphBuilder2("directed_graph_09.txt");
                _graph = _graphBuilder.Build();
                _scc = new Scc(_graph);
            }

            [TestMethod]
            public void Should_get_8_nodes_and_11_edges()
            {
                _graph.Nodes.Count.ShouldEqual(8);
                _graph.Edges.Count.ShouldEqual(11);
            }

            [TestMethod]
            public void Should_get_3_Sccs()
            {
                var result = _scc.Execute();
                result.Count.ShouldEqual(3);

                var result2 = result.OrderByDescending(x => x);
                string.Join(",", result2).ShouldEqual("6,1,1");
            }
        }

        [TestClass]
        public class WhenUsingDirectedGraph10
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Scc _scc;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new HwDirectedGraphBuilder2("directed_graph_10.txt");
                _graph = _graphBuilder.Build();
                _scc = new Scc(_graph);
            }

            [TestMethod]
            public void Should_get_4_nodes_and_4_edges()
            {
                _graph.Nodes.Count.ShouldEqual(4);
                _graph.Edges.Count.ShouldEqual(4);
            }

            [TestMethod]
            public void Should_get_2_Sccs()
            {
                var result = _scc.Execute();
                result.Count.ShouldEqual(2);

                var result2 = result.OrderByDescending(x => x);
                string.Join(",", result2).ShouldEqual("3,1");
            }
        }

        [TestClass]
        public class WhenUsingDirectedGraphHw
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Scc _scc;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new HwDirectedGraphBuilder2("directed_graph_hw.txt");
                _graph = _graphBuilder.Build();
                _scc = new Scc(_graph);
            }

            [TestMethod]
            public void Should_get_875714_nodes_and_5105043_edges()
            {
                _graph.Nodes.Count.ShouldEqual(875714);
                _graph.Edges.Count.ShouldEqual(5105043);
            }

            //[TestMethod]
            //public void Should_get_3_Sccs()
            //{
            //    var result = _scc.Execute();
            //    result.ShouldEqual(3);
            //}
        }
    }
}