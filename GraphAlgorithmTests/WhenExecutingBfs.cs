using System.Linq;
using GraphAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace GraphAlgorithmTests
{
    public class WhenExecutingBfs
    {
        [TestClass]
        public class WhenUsingUndirectedGraphLecture01
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Bfs _bfs;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new UndirectedGraphBuilder("undirected_graph_lecture_01.txt");
                _graph = _graphBuilder.Build();
                _bfs = new Bfs(_graph);
            }

            [TestMethod]
            public void The_shortest_path_should_be_3()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 1);
                _bfs.Execute(startingNode);

                var endNode = _graph.Nodes.Single(n => n.Label == 6);
                endNode.Distance.ShouldEqual(3);
            }

            [TestMethod]
            public void All_nodes_should_be_visited()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 1);
                _bfs.Execute(startingNode);

                _graph.Nodes.All(n => n.Visited).ShouldBeTrue();
            }

            [TestMethod]
            public void The_nodes_should_be_visited_in_layers()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 1);
                _bfs.Execute(startingNode);

                _graph.Nodes.Single(n => n.Label == 1).Distance.ShouldEqual(0);
                _graph.Nodes.Single(n => n.Label == 2).Distance.ShouldEqual(1);
                _graph.Nodes.Single(n => n.Label == 3).Distance.ShouldEqual(1);
                _graph.Nodes.Single(n => n.Label == 4).Distance.ShouldEqual(2);
                _graph.Nodes.Single(n => n.Label == 5).Distance.ShouldEqual(2);
                _graph.Nodes.Single(n => n.Label == 6).Distance.ShouldEqual(3);
            }
        }

        [TestClass]
        public class WhenUsingUndirectedGraphLecture02
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Bfs _bfs;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new UndirectedGraphBuilder("undirected_graph_lecture_02.txt");
                _graph = _graphBuilder.Build();
                _bfs = new Bfs(_graph);
            }

            [TestMethod]
            public void Then_only_connected_node_should_be_visited_01()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 1);
                _bfs.Execute(startingNode);

                var visited = new[] { 1, 3, 5, 7, 9 };
                visited.All(v => _graph.Nodes.Single(n => n.Label == v).Visited).ShouldBeTrue();

                _graph.Nodes.Where(n => !visited.Contains(n.Label)).All(n => n.Visited).ShouldBeFalse();
            }

            [TestMethod]
            public void Then_only_connected_node_should_be_visited_02()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 2);
                _bfs.Execute(startingNode);

                var visited = new[] { 2, 4 };
                visited.All(v => _graph.Nodes.Single(n => n.Label == v).Visited).ShouldBeTrue();

                _graph.Nodes.Where(n => !visited.Contains(n.Label)).All(n => n.Visited).ShouldBeFalse();
            }

            [TestMethod]
            public void Then_only_connected_node_should_be_visited_03()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 6);
                _bfs.Execute(startingNode);

                var visited = new[] { 6, 8, 10 };
                visited.All(v => _graph.Nodes.Single(n => n.Label == v).Visited).ShouldBeTrue();

                _graph.Nodes.Where(n => !visited.Contains(n.Label)).All(n => n.Visited).ShouldBeFalse();
            }
        }
    }
}