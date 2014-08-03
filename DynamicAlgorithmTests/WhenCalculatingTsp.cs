using DynamicAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace DynamicAlgorithmTests
{
    public class WhenCalculatingTsp
    {
        [TestClass]
        public class WhenCalculatingPathCombinations
        {
            [TestMethod]
            public void Should_contain_1_combination()
            {
                var c = new TspPathBitArrayGenerator();
                var cs = c.Generate(5, 5);

                cs.Length.ShouldEqual(1);
                cs.ShouldContain(31);
            }

            [TestMethod]
            public void Should_contain_2_combinations()
            {
                var c = new TspPathBitArrayGenerator();
                var cs = c.Generate(5, 2);

                cs.Length.ShouldEqual(4);
                cs.ShouldContain(3);
                cs.ShouldContain(5);
                cs.ShouldContain(9);
                cs.ShouldContain(17);
            }

            [TestMethod]
            public void Should_contain_6_combinations()
            {
                var c = new TspPathBitArrayGenerator();
                var cs = c.Generate(5, 3);

                cs.Length.ShouldEqual(6);
                cs.ShouldContain(7);
                cs.ShouldContain(11);
                cs.ShouldContain(19);
                cs.ShouldContain(13);
                cs.ShouldContain(21);
                cs.ShouldContain(25);
            }
        }

        [TestClass]
        public class WhenUsingDf01
        {
            private double[][] _data;

            [TestInitialize]
            public void Init()
            {
                _data = new TspFileReader(@".\tsp\tsp_df01.txt").Read();
            }

            [TestMethod]
            public void Should_contain_4_points()
            {
                _data.Length.ShouldEqual(4);
                _data[0].Length.ShouldEqual(2);

                _data[0][0].ShouldEqual(0.0);
                _data[0][1].ShouldEqual(0.0);
                _data[3][0].ShouldEqual(0.0);
                _data[3][1].ShouldEqual(1.0);
            }

            [TestMethod]
            public void Should_have_a_length_of_4()
            {
                var solver = new TspSolver(_data);
                var result = solver.Execute();
                result.ShouldEqual(4);
            }
        }

        [TestClass]
        public class WhenUsingDf02
        {
            private double[][] _data;

            [TestInitialize]
            public void Init()
            {
                _data = new TspFileReader(@".\tsp\tsp_df02.txt").Read();
            }

            [TestMethod]
            public void Should_contain_5_points()
            {
                _data.Length.ShouldEqual(5);
                _data[0].Length.ShouldEqual(2);

                _data[0][0].ShouldEqual(0.0);
                _data[0][1].ShouldEqual(2.0);
                _data[4][0].ShouldEqual(4.0);
                _data[4][1].ShouldEqual(2.0);
            }

            [TestMethod]
            public void Should_have_a_length_of_10()
            {
                var solver = new TspSolver(_data);
                var result = solver.Execute();
                result.ShouldEqual(10);
            }
        }

        [TestClass]
        public class WhenUsingDf03
        {
            private double[][] _data;

            [TestInitialize]
            public void Init()
            {
                _data = new TspFileReader(@".\tsp\tsp_df03.txt").Read();
            }

            [TestMethod]
            public void Should_contain_5_points()
            {
                _data.Length.ShouldEqual(5);
                _data[0].Length.ShouldEqual(2);

                _data[0][0].ShouldEqual(2.25);
                _data[0][1].ShouldEqual(1.62);
                _data[4][0].ShouldEqual(2.0);
                _data[4][1].ShouldEqual(1.0);
            }

            [TestMethod]
            public void Should_have_a_length_of_6()
            {
                var solver = new TspSolver(_data);
                var result = solver.Execute();
                result.ShouldEqual(6);
            }
        }

        [TestClass]
        public class WhenUsingDf04
        {
            private double[][] _data;

            [TestInitialize]
            public void Init()
            {
                _data = new TspFileReader(@".\tsp\tsp_df04.txt").Read();
            }

            [TestMethod]
            public void Should_contain_6_points()
            {
                _data.Length.ShouldEqual(6);
                _data[0].Length.ShouldEqual(2);

                _data[0][0].ShouldEqual(2.25);
                _data[0][1].ShouldEqual(1.62);
                _data[5][0].ShouldEqual(1.26);
                _data[5][1].ShouldEqual(0.79);
            }

            [TestMethod]
            public void Should_have_a_length_of_6()
            {
                var solver = new TspSolver(_data);
                var result = solver.Execute();
                result.ShouldEqual(6);
            }
        }

        [TestClass]
        public class WhenUsingDf05
        {
            private double[][] _data;

            [TestInitialize]
            public void Init()
            {
                _data = new TspFileReader(@".\tsp\tsp_df05.txt").Read();
            }

            [TestMethod]
            public void Should_contain_7_points()
            {
                _data.Length.ShouldEqual(7);
                _data[0].Length.ShouldEqual(2);

                _data[0][0].ShouldEqual(1.32);
                _data[0][1].ShouldEqual(56.4);
                _data[6][0].ShouldEqual(19.34);
                _data[6][1].ShouldEqual(34.2);
            }

            [TestMethod]
            public void Should_have_a_length_of_124()
            {
                var solver = new TspSolver(_data);
                var result = solver.Execute();
                result.ShouldEqual(124);
            }
        }

        [TestClass]
        public class WhenUsingDf06
        {
            private double[][] _data;

            [TestInitialize]
            public void Init()
            {
                _data = new TspFileReader(@".\tsp\tsp_df06.txt").Read();
            }

            [TestMethod]
            public void Should_contain_14_points()
            {
                _data.Length.ShouldEqual(14);
                _data[0].Length.ShouldEqual(2);

                _data[0][0].ShouldEqual(20833.3333);
                _data[0][1].ShouldEqual(17100.0);
                _data[13][0].ShouldEqual(25149.1667);
                _data[13][1].ShouldEqual(12365.8333);
            }

            [TestMethod]
            public void Should_have_a_length_of_16898()
            {
                var solver = new TspSolver(_data);
                var result = solver.Execute();
                result.ShouldEqual(16898);
            }
        }

        [TestClass]
        public class WhenUsingDf07
        {
            private double[][] _data;

            [TestInitialize]
            public void Init()
            {
                _data = new TspFileReader(@".\tsp\tsp_df07.txt").Read();
            }

            [TestMethod]
            public void Should_contain_16_points()
            {
                _data.Length.ShouldEqual(16);
                _data[0].Length.ShouldEqual(2);

                _data[0][0].ShouldEqual(20833.3333);
                _data[0][1].ShouldEqual(17100.0);
                _data[15][0].ShouldEqual(28166.6667);
                _data[15][1].ShouldEqual(12833.33331);
            }

            [TestMethod]
            public void Should_have_a_length_of_26714()
            {
                var solver = new TspSolver(_data);
                var result = solver.Execute();
                result.ShouldEqual(26714);
            }
        }

        [TestClass]
        public class WhenUsingHw
        {
            private double[][] _data;

            [TestInitialize]
            public void Init()
            {
                _data = new TspFileReader(@".\tsp\tsp_hw.txt").Read();
            }

            [TestMethod]
            public void Should_contain_25_points()
            {
                _data = new TspFileReader(@".\tsp\tsp_hw.txt").Read();
                _data.Length.ShouldEqual(25);
                _data[0].Length.ShouldEqual(2);

                _data[0][0].ShouldEqual(20833.3333);
                _data[0][1].ShouldEqual(17100.0);
                _data[24][0].ShouldEqual(27233.3333);
                _data[24][1].ShouldEqual(10450.0);
            }

            [TestMethod]
            public void Should_have_a_length_of_26442()
            {
                var solver = new TspSolver(_data);
                var result = solver.Execute();
                result.ShouldEqual(26442);
            }
        }
    }
}
