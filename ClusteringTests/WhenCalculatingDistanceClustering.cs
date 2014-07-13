using GraphAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace ClusteringTests
{
    public class WhenCalculatingDistanceClustering
    {
        //clustering_1_df1 - 134365 - 4 clusters
        //clustering_1_df2 - 7 - 4 clusters
        [TestClass]
        public class WhenUsingPointsInDf01
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private DistanceClustering _distanceClustering;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new DistanceClusteringGraphBuilder("clustering_1_df1.txt");
                _graph = _graphBuilder.Build();
                _distanceClustering = new DistanceClustering(_graph);
            }

            [TestMethod]
            public void Should_have_10_nodes_and_45_edges()
            {
                _graph.Nodes.Count.ShouldEqual(10);
                _graph.Edges.Count.ShouldEqual(45);
            }

            [TestMethod]
            public void Should_have_distance_134365_with_4_clusters()
            {
                var result = _distanceClustering.Execute(4);
                result.ShouldEqual(134365);
            }
        }

        [TestClass]
        public class WhenUsingPointsInDf02
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private DistanceClustering _distanceClustering;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new DistanceClusteringGraphBuilder("clustering_1_df2.txt");
                _graph = _graphBuilder.Build();
                _distanceClustering = new DistanceClustering(_graph);
            }

            [TestMethod]
            public void Should_have_6_nodes_and_15_edges()
            {
                _graph.Nodes.Count.ShouldEqual(6);
                _graph.Edges.Count.ShouldEqual(15);
            }

            [TestMethod]
            public void Should_have_distance_7_with_4_clusters()
            {
                var result = _distanceClustering.Execute(4);
                result.ShouldEqual(7);
            }
        }

        [TestClass]
        public class WhenUsingPointsInDf03
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private DistanceClustering _distanceClustering;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new DistanceClusteringGraphBuilder("clustering_1_df3.txt");
                _graph = _graphBuilder.Build();
                _distanceClustering = new DistanceClustering(_graph);
            }

            [TestMethod]
            public void Should_have_5_nodes_and_10_edges()
            {
                _graph.Nodes.Count.ShouldEqual(5);
                _graph.Edges.Count.ShouldEqual(10);
            }

            [TestMethod]
            public void Should_have_distance_2_with_4_clusters()
            {
                var result = _distanceClustering.Execute(4);
                result.ShouldEqual(2);
            }

            [TestMethod]
            public void Should_have_distance_3_with_3_clusters()
            {
                var result = _distanceClustering.Execute(3);
                result.ShouldEqual(3);
            }
        }

        [TestClass]
        public class WhenUsingPointsInDf04
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private DistanceClustering _distanceClustering;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new DistanceClusteringGraphBuilder("clustering_1_df4.txt");
                _graph = _graphBuilder.Build();
                _distanceClustering = new DistanceClustering(_graph);
            }

            [TestMethod]
            public void Should_have_7_nodes_and_21_edges()
            {
                _graph.Nodes.Count.ShouldEqual(7);
                _graph.Edges.Count.ShouldEqual(21);
            }

            [TestMethod]
            public void Should_have_distance_27_with_4_clusters()
            {
                var result = _distanceClustering.Execute(4);
                result.ShouldEqual(27);
            }

            [TestMethod]
            public void Should_have_distance_28_with_3_clusters()
            {
                var result = _distanceClustering.Execute(3);
                result.ShouldEqual(28);
            }
        }

        [TestClass]
        public class WhenUsingPointsInHw
        {
            private IGraphBuilder _graphBuilder;
            private IGraph _graph;
            private DistanceClustering _distanceClustering;

            [TestInitialize]
            public void Init()
            {
                _graphBuilder = new DistanceClusteringGraphBuilder("clustering_1_hw.txt");
                _graph = _graphBuilder.Build();
                _distanceClustering = new DistanceClustering(_graph);
            }

            [TestMethod]
            public void Should_have_500_nodes_and_124750_edges()
            {
                _graph.Nodes.Count.ShouldEqual(500);
                _graph.Edges.Count.ShouldEqual(124750);
            }

            [TestMethod]
            public void Should_have_distance_7_with_4_clusters()
            {
                var result = _distanceClustering.Execute(4);
                result.ShouldEqual(106);
            }
        }
    }
}
