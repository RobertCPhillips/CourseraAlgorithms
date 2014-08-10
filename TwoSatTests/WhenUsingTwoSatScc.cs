using System.Linq;
using GraphAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace TwoSatTests
{
    public class WhenUsingTwoSatScc
    {
        [TestClass]
        public class WhenUsingDf01
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("df01_2sat.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_4_nodes_and_4_edges()
            {
                _graph.Nodes.Count.ShouldEqual(4);
                _graph.Edges.Count.ShouldEqual(4);

                _graph.Edges.Count(e => e.Left.Label == -1 &&
                                        e.Right.Label == 2 &&
                                        e.Direction == EdgeDirection.LeftToRight)
                            .ShouldEqual(1);

                _graph.Edges.Count(e => e.Left.Label == -2 &&
                                        e.Right.Label == 1 &&
                                        e.Direction == EdgeDirection.LeftToRight)
                            .ShouldEqual(1);

                _graph.Edges.Count(e => e.Left.Label == 1 &&

                                        e.Right.Label == -2 &&
                                        e.Direction == EdgeDirection.LeftToRight)
                            .ShouldEqual(1);

                _graph.Edges.Count(e => e.Left.Label == 2 &&
                                        e.Right.Label == -1 &&
                                        e.Direction == EdgeDirection.LeftToRight)
                            .ShouldEqual(1);
            }

            [TestMethod]
            public void Then_the_constraints_are_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeTrue();
            }
        }

        [TestClass]
        public class WhenUsingDf02
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("df02_2sat.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_4_nodes_and_4_edges()
            {
                _graph.Nodes.Count.ShouldEqual(4);
                _graph.Edges.Count.ShouldEqual(4);
            }

            [TestMethod]
            public void Then_the_constraints_are_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeTrue();
            }
        }

        [TestClass]
        public class WhenUsingDf03
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("df03_2sat.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_4_nodes_and_8_edges()
            {
                _graph.Nodes.Count.ShouldEqual(4);
                _graph.Edges.Count.ShouldEqual(8);
            }

            [TestMethod]
            public void Then_the_constraints_are_not_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeFalse();
            }
        }

        [TestClass]
        public class WhenUsingDf04
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("df04_2sat.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_8_nodes_and_10_edges()
            {
                _graph.Nodes.Count.ShouldEqual(8);
                _graph.Edges.Count.ShouldEqual(10);
            }

            [TestMethod]
            public void Then_the_constraints_are_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeTrue();
            }
        }

        [TestClass]
        public class WhenUsingDf05
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("df05_2sat.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_6_nodes_and_12_edges()
            {
                _graph.Nodes.Count.ShouldEqual(6);
                _graph.Edges.Count.ShouldEqual(12);
            }

            [TestMethod]
            public void Then_the_constraints_are_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeTrue();
            }
        }

        [TestClass]
        public class WhenUsingDf06
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("df06_2sat.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_8_nodes_and_12_edges()
            {
                _graph.Nodes.Count.ShouldEqual(8);
                _graph.Edges.Count.ShouldEqual(12);
            }

            [TestMethod]
            public void Then_the_constraints_are_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeTrue();
            }
        }

        [TestClass]
        public class WhenUsingDf07
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("df07_2sat.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_16_nodes_and_18_edges()
            {
                _graph.Nodes.Count.ShouldEqual(16);
                _graph.Edges.Count.ShouldEqual(18);
            }

            [TestMethod]
            public void Then_the_constraints_are_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeTrue();
            }
        }

        [TestClass]
        public class WhenUsingDf08
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("df08_2sat.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_16_nodes_and_20_edges()
            {
                _graph.Nodes.Count.ShouldEqual(16);
                _graph.Edges.Count.ShouldEqual(20);
            }

            [TestMethod]
            public void Then_the_constraints_are_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeTrue();
            }
        }

        [TestClass]
        public class WhenUsingDf09
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("df09_2sat.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_16_nodes_and_26_edges()
            {
                _graph.Nodes.Count.ShouldEqual(16);
                _graph.Edges.Count.ShouldEqual(26);
            }

            [TestMethod]
            public void Then_the_constraints_are_not_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeFalse();
            }
        }

        [TestClass]
        public class WhenUsingDf10
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("df10_2sat.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_16_nodes_and_26_edges()
            {
                _graph.Nodes.Count.ShouldEqual(16);
                _graph.Edges.Count.ShouldEqual(26);
            }

            [TestMethod]
            public void Then_the_constraints_are_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeTrue();
            }
        }

        [TestClass]
        public class WhenUsingDf11
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("df11_2sat.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_24_nodes_and_50_edges()
            {
                _graph.Nodes.Count.ShouldEqual(24);
                _graph.Edges.Count.ShouldEqual(50);
            }

            [TestMethod]
            public void Then_the_constraints_are_not_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeFalse();
            }
        }

        [TestClass]
        public class WhenUsingDf12
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("df12_2sat.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_24_nodes_and_50_edges()
            {
                _graph.Nodes.Count.ShouldEqual(24);
                _graph.Edges.Count.ShouldEqual(50);
            }

            [TestMethod]
            public void Then_the_constraints_are_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeTrue();
            }
        }

        [TestClass]
        public class WhenUsingHw1
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("hw_2sat1.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_200000_edges()
            {
                _graph.Edges.Count.ShouldEqual(200000);
            }

            [TestMethod]
            public void Then_the_constraints_are_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeTrue();
            }
        }

        [TestClass]
        public class WhenUsingHw2
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("hw_2sat2.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_400000_edges()
            {
                _graph.Edges.Count.ShouldEqual(400000);
            }

            [TestMethod]
            public void Then_the_constraints_are_not_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeFalse();
            }
        }

        [TestClass]
        public class WhenUsingHw3
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("hw_2sat3.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_800000_edges()
            {
                _graph.Edges.Count.ShouldEqual(800000);
            }

            [TestMethod]
            public void Then_the_constraints_are_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeTrue();
            }
        }

        [TestClass]
        public class WhenUsingHw4
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("hw_2sat4.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_1200000_edges()
            {
                _graph.Edges.Count.ShouldEqual(1200000);
            }

            [TestMethod]
            public void Then_the_constraints_are_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeTrue();
            }
        }

        [TestClass]
        public class WhenUsingHw5
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("hw_2sat5.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_1600000_edges()
            {
                _graph.Edges.Count.ShouldEqual(1600000);
            }

            [TestMethod]
            public void Then_the_constraints_are_not_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeFalse();
            }
        }

        [TestClass]
        public class WhenUsingHw6
        {
            private IGraph _graph;

            [TestInitialize]
            public void Init()
            {
                var graphBuilder = new TwoSatGraphBuilder("hw_2sat6.txt");
                _graph = graphBuilder.Build();
            }

            [TestMethod]
            public void Then_the_graph_should_have_2000000_edges()
            {
                _graph.Edges.Count.ShouldEqual(2000000);
            }

            [TestMethod]
            public void Then_the_constraints_are_not_satisfiable()
            {
                var scc = new TwoSatScc(_graph);
                scc.Execute().ShouldBeFalse();
            }
        }
    }
}
