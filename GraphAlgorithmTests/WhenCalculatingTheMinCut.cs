using GraphAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace GraphAlgorithmTests
{
    public class WhenCalculatingTheMinCut
    {
        [TestClass]
        public class WhenUsingTheHwDataFile
        {
            private IGraph _graph;
            private IGraphBuilder _graphBuilder;

            [TestInitialize]
            public void Init()
            {
                //arrange 
                _graphBuilder = new UndirectedGraphBuilder("kargerMinCut.txt");

                //act
                _graph = _graphBuilder.Build();
            }

            [TestMethod]
            public void Should_be_able_to_read_the_file()
            {
                //assert
                _graph.Nodes.Count.ShouldEqual(200);
            }

            [TestMethod]
            public void Should_produce_result_for_hw()
            {
                var cutter = new GraphMinimumCut(_graphBuilder);
                var result = cutter.GetMinCut();

                result.ShouldEqual(17);
            }
        }

        [TestClass]
        public class WhenUsingThe01DataFile
        {
            private IGraph _graph;
            private IGraphBuilder _graphBuilder;

            [TestInitialize]
            public void Init()
            {
                //arrange 
                _graphBuilder = new UndirectedGraphBuilder("kargerMinCut01.txt");

                //act
                _graph = _graphBuilder.Build();
            }

            /*
             * expected result: 2
             * cuts are [(1,7), (4,5)]
             */

            [TestMethod]
            public void Should_be_able_to_read_the_file()
            {
                //assert
                _graph.Nodes.Count.ShouldEqual(8);
                _graph.Edges.Count.ShouldEqual(14);
            }

            [TestMethod]
            public void Should_get_a_cut_of_2()
            {
                var cutter = new GraphMinimumCut(_graphBuilder);
                var result = cutter.GetMinCut();

                result.ShouldEqual(2);
            }
        }

        [TestClass]
        public class WhenUsingThe02DataFile
        {
            private IGraph _graph;
            private IGraphBuilder _graphBuilder;

            [TestInitialize]
            public void Init()
            {
                //arrange 
                _graphBuilder = new UndirectedGraphBuilder("kargerMinCut02.txt");

                //act
                _graph = _graphBuilder.Build();
            }

            /*
             * expected result: 2
             * cuts are [(1,7), (4,5)]
             */

            [TestMethod]
            public void Should_be_able_to_read_the_file()
            {
                //assert
                _graph.Nodes.Count.ShouldEqual(8);
            }

            [TestMethod]
            public void Should_get_a_cut_of_2()
            {
                var cutter = new GraphMinimumCut(_graphBuilder);
                var result = cutter.GetMinCut();

                result.ShouldEqual(2);
            }
        }

        [TestClass]
        public class WhenUsingThe03DataFile
        {
            private IGraph _graph;
            private IGraphBuilder _graphBuilder;

            [TestInitialize]
            public void Init()
            {
                //arrange 
                _graphBuilder = new UndirectedGraphBuilder("kargerMinCut03.txt");

                //act
                _graph = _graphBuilder.Build();
            }

            /*
             * expected result: 1
             * cut is [(4,5)]
             */

            [TestMethod]
            public void Should_be_able_to_read_the_file()
            {
                _graph.Nodes.Count.ShouldEqual(8);
            }

            [TestMethod]
            public void Should_get_a_cut_of_1()
            {
                var cutter = new GraphMinimumCut(_graphBuilder);
                var result = cutter.GetMinCut();

                result.ShouldEqual(1);
            }
        }

        [TestClass]
        public class WhenUsingThe04DataFile
        {
            private IGraph _graph;
            private IGraphBuilder _graphBuilder;

            [TestInitialize]
            public void Init()
            {
                //arrange 
                _graphBuilder = new UndirectedGraphBuilder("kargerMinCut04.txt");

                //act
                _graph = _graphBuilder.Build();
            }

            /*
             * expected result: 1
             * cut is [(4,5)]
             */

            [TestMethod]
            public void Should_be_able_to_read_the_file()
            {
                _graph.Nodes.Count.ShouldEqual(8);
            }

            [TestMethod]
            public void Should_get_a_cut_of_1()
            {
                var cutter = new GraphMinimumCut(_graphBuilder);
                var result = cutter.GetMinCut();

                result.ShouldEqual(1);
            }
        }

        [TestClass]
        public class WhenUsingThe05DataFile
        {
            private IGraph _graph;
            private IGraphBuilder _graphBuilder;

            [TestInitialize]
            public void Init()
            {
                //arrange 
                _graphBuilder = new UndirectedGraphBuilder("kargerMinCut05.txt");

                //act
                _graph = _graphBuilder.Build();
            }

            /*
             * expected result: 3
             */

            [TestMethod]
            public void Should_be_able_to_read_the_file()
            {
                _graph.Nodes.Count.ShouldEqual(40);
            }

            [TestMethod]
            public void Should_get_a_cut_of_3()
            {
                var cutter = new GraphMinimumCut(_graphBuilder);
                var result = cutter.GetMinCut();

                result.ShouldEqual(3);
            }
        }
    }
}
