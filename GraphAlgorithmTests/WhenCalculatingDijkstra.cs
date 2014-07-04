using System;
using System.Linq;
using GraphAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace GraphAlgorithmTests
{
    public class WhenCalculatingDijkstra
    {
        [TestClass]
        public class WhenUsingHwGraph
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Dijkstra _dijkstra;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new DijkstraGraphBuilder("dijkstra_graph_hw.txt");
                _graph = _graphBuilder.Build();
                _dijkstra = new Dijkstra(_graph);
            }

            [TestMethod]
            public void Should_get_200_nodes_and_1867_edges()
            {
                //node count
                _graph.Nodes.Count.ShouldEqual(200);
                //edge count??
                _graph.Edges.Count.ShouldEqual(1867);

                //spot check
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 1 && e.Right.Label == 163 && e.Weight == 8164).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 1 && e.Right.Label == 145  && e.Weight == 648).ShouldNotBeNull();

                //edge setup verification
                foreach (var e in _graph.Edges)
                {
                    (e.Left.Label < e.Right.Label).ShouldBeTrue(String.Format("{0} has right >= left", e));
                }
            }

            [TestMethod]
            public void Should_find_shortest_path_cost_of_each_node()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 1);
                var result = _dijkstra.Execute(startingNode);

                result.Length.ShouldEqual(200 + 1);

                //7,37,59,82,99,115,133,165,188,197
                result[1].Distance.ShouldEqual(0);

                result[7].Distance.ShouldEqual(2599);
                result[37].Distance.ShouldEqual(2610);
                result[59].Distance.ShouldEqual(2947);
                result[82].Distance.ShouldEqual(2052);
                result[99].Distance.ShouldEqual(2367);
                result[115].Distance.ShouldEqual(2399);
                result[133].Distance.ShouldEqual(2029);
                result[165].Distance.ShouldEqual(2442);
                result[188].Distance.ShouldEqual(2505);
                result[197].Distance.ShouldEqual(3068);

                var answer = String.Join(",",new[]
                {
                    result[7].Distance,
                    result[37].Distance,
                    result[59].Distance,
                    result[82].Distance,
                    result[99].Distance,
                    result[115].Distance,
                    result[133].Distance,
                    result[165].Distance,
                    result[188].Distance,
                    result[197].Distance
                });

                answer.ShouldEqual("2599,2610,2947,2052,2367,2399,2029,2442,2505,3068");
            }
        }

        [TestClass]
        public class WhenUsingDfGraph01
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Dijkstra _dijkstra;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new DijkstraGraphBuilder("dijkstra_graph_01.txt");
                _graph = _graphBuilder.Build();
                _dijkstra = new Dijkstra(_graph);
            }

            [TestMethod]
            public void Should_get_4_nodes_and_5_edges()
            {
                //node count
                _graph.Nodes.Count.ShouldEqual(4);
                //edge count
                _graph.Edges.Count.ShouldEqual(5);

                //spot check
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 1 && e.Right.Label == 2 && e.Weight == 3).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 1 && e.Right.Label == 3 && e.Weight == 3).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 2 && e.Right.Label == 4 && e.Weight == 2).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 2 && e.Right.Label == 3 && e.Weight == 1).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 3 && e.Right.Label == 4 && e.Weight == 50).ShouldNotBeNull();

                //edge setup verification
                foreach (var e in _graph.Edges)
                {
                    (e.Left.Label < e.Right.Label).ShouldBeTrue(String.Format("{0} has right >= left", e));
                }
            }

            [TestMethod]
            public void Should_find_shortest_path_cost_of_each_node()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 1);
                var result = _dijkstra.Execute(startingNode);

                result.Length.ShouldEqual(4 + 1);

                result[1].Distance.ShouldEqual(0);
                result[2].Distance.ShouldEqual(3);
                result[3].Distance.ShouldEqual(3);
                result[4].Distance.ShouldEqual(5);
            }
        }

        [TestClass]
        public class WhenUsingDfGraph02
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Dijkstra _dijkstra;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new DijkstraGraphBuilder("dijkstra_graph_02.txt");
                _graph = _graphBuilder.Build();
                _dijkstra = new Dijkstra(_graph);
            }

            [TestMethod]
            public void Should_get_4_nodes_and_5_edges()
            {
                //node count
                _graph.Nodes.Count.ShouldEqual(4);
                //edge count
                _graph.Edges.Count.ShouldEqual(5);

                //spot check
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 1 && e.Right.Label == 2 && e.Weight == 3).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 1 && e.Right.Label == 3 && e.Weight == 5).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 2 && e.Right.Label == 4 && e.Weight == 2).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 2 && e.Right.Label == 3 && e.Weight == 1).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 3 && e.Right.Label == 4 && e.Weight == 50).ShouldNotBeNull();

                //edge setup verification
                foreach (var e in _graph.Edges)
                {
                    (e.Left.Label < e.Right.Label).ShouldBeTrue(String.Format("{0} has right >= left", e));
                }
            }

            [TestMethod]
            public void Should_find_shortest_path_cost_of_each_node()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 1);
                var result = _dijkstra.Execute(startingNode);

                result.Length.ShouldEqual(4 + 1);

                result[1].Distance.ShouldEqual(0);
                result[2].Distance.ShouldEqual(3);
                result[3].Distance.ShouldEqual(4);
                result[4].Distance.ShouldEqual(5);
            }
        }

        [TestClass]
        public class WhenUsingDfGraph03
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Dijkstra _dijkstra;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new DijkstraGraphBuilder("dijkstra_graph_03.txt");
                _graph = _graphBuilder.Build();
                _dijkstra = new Dijkstra(_graph);
            }

            [TestMethod]
            public void Should_get_4_nodes_and_5_edges()
            {
                //node count
                _graph.Nodes.Count.ShouldEqual(4);
                //edge count
                _graph.Edges.Count.ShouldEqual(5);

                //spot check
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 1 && e.Right.Label == 2 && e.Weight == 3).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 1 && e.Right.Label == 3 && e.Weight == 4).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 2 && e.Right.Label == 4 && e.Weight == 2).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 2 && e.Right.Label == 3 && e.Weight == 1).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 3 && e.Right.Label == 4 && e.Weight == 50).ShouldNotBeNull();

                //edge setup verification
                foreach (var e in _graph.Edges)
                {
                    (e.Left.Label < e.Right.Label).ShouldBeTrue(String.Format("{0} has right >= left", e));
                }
            }

            [TestMethod]
            public void Should_find_shortest_path_cost_of_each_node()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 1);
                var result = _dijkstra.Execute(startingNode);

                result.Length.ShouldEqual(4 + 1);

                result[1].Distance.ShouldEqual(0);
                result[2].Distance.ShouldEqual(3);
                result[3].Distance.ShouldEqual(4);
                result[4].Distance.ShouldEqual(5);
            }
        }

        [TestClass]
        public class WhenUsingDfGraph04
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Dijkstra _dijkstra;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new DijkstraGraphBuilder("dijkstra_graph_04.txt");
                _graph = _graphBuilder.Build();
                _dijkstra = new Dijkstra(_graph);
            }

            [TestMethod]
            public void Should_get_4_nodes_and_5_edges()
            {
                //node count
                _graph.Nodes.Count.ShouldEqual(4);
                //edge count
                _graph.Edges.Count.ShouldEqual(5);

                //spot check
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 1 && e.Right.Label == 2 && e.Weight == 8).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 1 && e.Right.Label == 3 && e.Weight == 15).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 2 && e.Right.Label == 4 && e.Weight == 5).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 2 && e.Right.Label == 3 && e.Weight == 4).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 3 && e.Right.Label == 4 && e.Weight == 5).ShouldNotBeNull();

                //edge setup verification
                foreach (var e in _graph.Edges)
                {
                    (e.Left.Label < e.Right.Label).ShouldBeTrue(String.Format("{0} has right >= left", e));
                }
            }

            [TestMethod]
            public void Should_find_shortest_path_cost_of_each_node()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 1);
                var result = _dijkstra.Execute(startingNode);

                result.Length.ShouldEqual(4 + 1);

                result[1].Distance.ShouldEqual(0);
                result[2].Distance.ShouldEqual(8);
                result[3].Distance.ShouldEqual(12);
                result[4].Distance.ShouldEqual(13);
            }
        }

        [TestClass]
        public class WhenUsingDfGraph05
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Dijkstra _dijkstra;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new DijkstraGraphBuilder("dijkstra_graph_05.txt");
                _graph = _graphBuilder.Build();
                _dijkstra = new Dijkstra(_graph);
            }

            [TestMethod]
            public void Should_get_7_nodes_and_12_edges()
            {
                //node count
                _graph.Nodes.Count.ShouldEqual(7);
                //edge count
                _graph.Edges.Count.ShouldEqual(12);

                //spot check
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 1 && e.Right.Label == 4 && e.Weight == 1).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 2 && e.Right.Label == 4 && e.Weight == 3).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 3 && e.Right.Label == 4 && e.Weight == 2).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 4 && e.Right.Label == 5 && e.Weight == 2).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 4 && e.Right.Label == 6 && e.Weight == 8).ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 4 && e.Right.Label == 7 && e.Weight == 4).ShouldNotBeNull();

                //edge setup verification
                foreach (var e in _graph.Edges)
                {
                    (e.Left.Label < e.Right.Label).ShouldBeTrue(String.Format("{0} has right >= left", e));
                }
            }

            [TestMethod]
            public void Should_find_shortest_path_cost_of_each_node()
            {
                var startingNode = _graph.Nodes.Single(n => n.Label == 1);
                var result = _dijkstra.Execute(startingNode);

                result.Length.ShouldEqual(7 + 1);

                result[1].Distance.ShouldEqual(0);
                result[2].Distance.ShouldEqual(2);
                result[3].Distance.ShouldEqual(3);
                result[4].Distance.ShouldEqual(1);
                result[5].Distance.ShouldEqual(3);
                result[6].Distance.ShouldEqual(6);
                result[7].Distance.ShouldEqual(5);
            }
        }
    }
}