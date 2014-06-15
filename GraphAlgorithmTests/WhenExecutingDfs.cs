using System.Linq;
using GraphAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace GraphAlgorithmTests
{
    public class WhenExecutingDfs
    {
        [TestClass]
        public class WhenUsingUndirectedGraphLecture03
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Dfs _dfs;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new UndirectedGraphBuilder("undirected_graph_lecture_03.txt");
                _graph = _graphBuilder.Build();
                _dfs = new Dfs(_graph);
            }

            [TestMethod]
            public void All_nodes_should_be_visited()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 1);
                _dfs.Execute(startingNode);

                _graph.Nodes.All(n => n.Visited).ShouldBeTrue();
            }
        }

        [TestClass]
        public class WhenUsingDirectedGraph01
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Dfs _dfs;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new HwDirectedGraphBuilder2("directed_graph_01.txt");
                _graph = _graphBuilder.Build();
                _dfs = new Dfs(_graph);
            }

            [TestMethod]
            public void Should_get_6_nodes_and_7_edges()
            {
                _graph.Nodes.Count.ShouldEqual(6);
                _graph.Edges.Count.ShouldEqual(7);
            }

            [TestMethod]
            public void All_nodes_should_be_visited()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 1);
                _dfs.Execute(startingNode);

                _graph.Nodes.All(n => n.Visited).ShouldBeTrue();
            }

            [TestMethod]
            public void The_nodes_should_be_sorted()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 1);
                _dfs.Execute(startingNode);

                _graph.Nodes.Single(n => n.Label == 1).Sort.ShouldEqual(1);
                _graph.Nodes.Single(n => n.Label == 2).Sort.ShouldEqual(2);
                _graph.Nodes.Single(n => n.Label == 3).Sort.ShouldEqual(3);
                _graph.Nodes.Single(n => n.Label == 4).Sort.ShouldEqual(4);
                _graph.Nodes.Single(n => n.Label == 5).Sort.ShouldEqual(5);
                _graph.Nodes.Single(n => n.Label == 6).Sort.ShouldEqual(6);
            }
        }

        [TestClass]
        public class WhenUsingDirectedGraph02
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Dfs _dfs;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new HwDirectedGraphBuilder2("directed_graph_02.txt");
                _graph = _graphBuilder.Build();
                _dfs = new Dfs(_graph);
            }

            [TestMethod]
            public void Should_get_6_nodes_and_8_edges()
            {
                _graph.Nodes.Count.ShouldEqual(6);
                _graph.Edges.Count.ShouldEqual(8);
            }

            [TestMethod]
            public void Only_nodes_connected_to_1_should_be_visited()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 1);
                _dfs.Execute(startingNode);

                _graph.Nodes.All(n => n.Visited).ShouldBeFalse();

                _graph.Nodes.Single(n => n.Label == 1).Visited.ShouldBeTrue();
                _graph.Nodes.Single(n => n.Label == 2).Visited.ShouldBeTrue();
                _graph.Nodes.Single(n => n.Label == 4).Visited.ShouldBeTrue();
                _graph.Nodes.Single(n => n.Label == 5).Visited.ShouldBeTrue();
            }

            [TestMethod]
            public void Only_nodes_connected_to_3_should_be_visited()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 3);
                _dfs.Execute(startingNode);

                _graph.Nodes.All(n => n.Visited).ShouldBeFalse();

                _graph.Nodes.Single(n => n.Label == 2).Visited.ShouldBeTrue();
                _graph.Nodes.Single(n => n.Label == 3).Visited.ShouldBeTrue();
                _graph.Nodes.Single(n => n.Label == 4).Visited.ShouldBeTrue();
                _graph.Nodes.Single(n => n.Label == 5).Visited.ShouldBeTrue();
            }

            [TestMethod]
            public void Only_nodes_connected_to_6_should_be_visited()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 6);
                _dfs.Execute(startingNode);

                _graph.Nodes.All(n => n.Visited).ShouldBeFalse();

                _graph.Nodes.Single(n => n.Label == 6).Visited.ShouldBeTrue();
            }
        }
    }
}