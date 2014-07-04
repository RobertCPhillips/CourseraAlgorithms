using System.Linq;
using GraphAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace GraphAlgorithmTests
{
    public class WhenCalculatingMstPrim
    {
        [TestClass]
        public class WhenUsingHwGraph
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Prim _prim;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new PrimGraphBuilder("prim_hw.txt");
                _graph = _graphBuilder.Build();
                _prim = new Prim(_graph);
            }
            
            [TestMethod]
            public void Should_get_500_nodes_and_2184_edges()
            {
                //node count
                _graph.Nodes.Count.ShouldEqual(500);
                //edge count
                _graph.Edges.Count.ShouldEqual(2184);

                //spot check
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 1 && e.Right.Label == 2 && e.Weight == 6807)
                    .ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 15 && e.Right.Label == 16 && e.Weight == -7753)
                    .ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 496 && e.Right.Label == 500 && e.Weight == -1519)
                    .ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 473 && e.Right.Label == 500 && e.Weight == 1052)
                    .ShouldNotBeNull();
            }

            [TestMethod]
            public void Should_compute_neg_3612829()
            {
                var result = _prim.Execute();
                result.ShouldEqual(-3612829);
            }
        }

        [TestClass]
        public class WhenUsingDfGraph01
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private Prim _prim;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new PrimGraphBuilder("prim_df_01.txt");
                _graph = _graphBuilder.Build();
                _prim = new Prim(_graph);
            }

            [TestMethod]
            public void Should_get_6_nodes_and_7_edges()
            {
                //node count
                _graph.Nodes.Count.ShouldEqual(6);
                //edge count
                _graph.Edges.Count.ShouldEqual(7);

                //spot check
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 1 && e.Right.Label == 2 && e.Weight == 2474)
                    .ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 4 && e.Right.Label == 3 && e.Weight == 640)
                    .ShouldNotBeNull();
                _graph.Edges.SingleOrDefault(e => e.Left.Label == 5 && e.Right.Label == 1 && e.Weight == -3824)
                    .ShouldNotBeNull();
            }

            [TestMethod]
            public void Should_compute_2624()
            {
                var result = _prim.Execute();
                result.ShouldEqual(2624);
            }
        }
    }
}