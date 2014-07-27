using GraphAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace GraphAlgorithmTests.apsp
{
    public class WhenCalculatingApSpWithBellmanFord
    {
        [TestClass]
        public class WhenUsingVl1
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var builder = new ApSpGraphBuilder(@".\apsp\vl_g1.txt");
                _graph = builder.Build();
            }

            [TestMethod]
            public void Should_get_6_nodes_and_7_edges()
            {
                _graph.Nodes.Count.ShouldEqual(6);
                _graph.Edges.Count.ShouldEqual(7);
            }

            [TestMethod]
            public void Should_have_shortest_path_of_neg_6_when_start_node_is_1()
            {
                var calc = new ApSpBellmanFord(_graph);
                var result = calc.Execute(1);
                result.ShouldEqual(-6);
            }

            [TestMethod]
            public void Should_have_shortest_path_of_neg_6()
            {
                var calc = new ApSpBellmanFordAllVertices(_graph);
                var result = calc.Execute();
                result.ShouldEqual(-6);
            }
        }
        [TestClass]
        public class WhenUsingVl2
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var builder = new ApSpGraphBuilder(@".\apsp\vl_g2.txt");
                _graph = builder.Build();
            }

            [TestMethod]
            public void Should_get_5_nodes_and_6_edges()
            {
                _graph.Nodes.Count.ShouldEqual(5);
                _graph.Edges.Count.ShouldEqual(6);
            }

            [TestMethod]
            public void Should_have_shortest_path_of_2_when_start_node_is_1()
            {
                var calc = new ApSpBellmanFord(_graph);
                var result = calc.Execute(1);
                result.ShouldEqual(2);
            }

            [TestMethod]
            public void Should_have_shortest_path_of_1_when_start_node_is_2()
            {
                var calc = new ApSpBellmanFord(_graph);
                var result = calc.Execute(2);
                result.ShouldEqual(1);
            }

            [TestMethod]
            public void Should_have_shortest_path_of_1()
            {
                var calc = new ApSpBellmanFordAllVertices(_graph);
                var result = calc.Execute();
                result.ShouldEqual(1);
            }
        }

        [TestClass]
        public class WhenUsingDf1
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var builder = new ApSpGraphBuilder(@".\apsp\df_g1.txt");
                _graph = builder.Build();
            }

            [TestMethod]
            public void Should_get_4_nodes_and_5_edges()
            {
                _graph.Nodes.Count.ShouldEqual(4);
                _graph.Edges.Count.ShouldEqual(5);
            }

            [TestMethod]
            public void Should_have_shortest_path_of_neg_2_when_start_node_is_4()
            {
                var calc = new ApSpBellmanFord(_graph);
                var result = calc.Execute(4);
                result.ShouldEqual(-2);
            }

            [TestMethod]
            public void Should_have_shortest_path_of_neg_2()
            {
                var calc = new ApSpBellmanFordAllVertices(_graph);
                var result = calc.Execute();
                result.ShouldEqual(-2);
            }
        }

        [TestClass]
        public class WhenUsingDf2
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var builder = new ApSpGraphBuilder(@".\apsp\df_g2.txt");
                _graph = builder.Build();
            }

            [TestMethod]
            public void Should_get_8_nodes_and_11_edges()
            {
                _graph.Nodes.Count.ShouldEqual(8);
                _graph.Edges.Count.ShouldEqual(11);
            }

            [TestMethod]
            public void Should_have_shortest_path_of_neg_4_when_start_node_is_7()
            {
                var calc = new ApSpBellmanFord(_graph);
                var result = calc.Execute(7);
                result.ShouldEqual(-4);
            }

            [TestMethod]
            public void Should_have_shortest_path_of_neg_4()
            {
                var calc = new ApSpBellmanFordAllVertices(_graph);
                var result = calc.Execute();
                result.ShouldEqual(-4);
            }
        }

        [TestClass]
        public class WhenUsingDf3
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var builder = new ApSpGraphBuilder(@".\apsp\df_g3.txt");
                _graph = builder.Build();
            }

            [TestMethod]
            public void Should_get_8_nodes_and_11_edges()
            {
                _graph.Nodes.Count.ShouldEqual(8);
                _graph.Edges.Count.ShouldEqual(11);
            }

            [TestMethod]
            public void Should_have_a_neg_cost_cycle()
            {
                var calc = new ApSpBellmanFordAllVertices(_graph);
                var result = calc.Execute();
                result.ShouldEqual(int.MinValue);
            }
        }

        [TestClass]
        public class WhenUsingHw1
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var builder = new ApSpGraphBuilder(@".\apsp\hw_g1.txt");
                _graph = builder.Build();
            }

            [TestMethod]
            public void Should_get_1000_nodes_and_47978_edges()
            {
                _graph.Nodes.Count.ShouldEqual(1000);
                _graph.Edges.Count.ShouldEqual(47978);
            }

            [TestMethod][Ignore]
            public void Should_have_a_neg_cost_cycle()
            {
                var calc = new ApSpBellmanFordAllVertices(_graph);
                var result = calc.Execute();
                result.ShouldEqual(int.MinValue);
            }
        }

        [TestClass]
        public class WhenUsingHw2
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var builder = new ApSpGraphBuilder(@".\apsp\hw_g2.txt");
                _graph = builder.Build();
            }

            [TestMethod]
            public void Should_get_1000_nodes_and_47978_edges()
            {
                _graph.Nodes.Count.ShouldEqual(1000);
                _graph.Edges.Count.ShouldEqual(47978);
            }

            [TestMethod][Ignore]
            public void Should_have_a_neg_cost_cycle()
            {
                var calc = new ApSpBellmanFordAllVertices(_graph);
                var result = calc.Execute();
                result.ShouldEqual(int.MinValue);
            }
        }

        [TestClass]
        public class WhenUsingHw3
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var builder = new ApSpGraphBuilder(@".\apsp\hw_g3.txt");
                _graph = builder.Build();
            }

            [TestMethod]
            public void Should_get_1000_nodes_and_47978_edges()
            {
                _graph.Nodes.Count.ShouldEqual(1000);
                _graph.Edges.Count.ShouldEqual(47978);
            }

            [TestMethod][Ignore]
            public void Should_have_shortest_path_of_neg_19()
            {
                var calc = new ApSpBellmanFordAllVertices(_graph);
                var result = calc.Execute();
                result.ShouldEqual(-19);
            }
        }
    }
}
