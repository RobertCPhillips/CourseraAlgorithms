using DynamicAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace DynamicAlgorithmTests
{
    public class WhenCalculatingKnapsackIterative
    {
        [TestClass]
        public class WhenUsingDf01
        {
            [TestMethod]
            public void Should_get_a_result_of_60()
            {
                var problem = new KnapsackFileReader(@".\knapsack\knapsack_1_df01.txt").Read();
                var ks = new KnapsackIterativeSolver(problem);
                var result = ks.Execute();
                result.ShouldEqual(60);
            }
        }
        [TestClass]
        public class WhenUsingDf02
        {
            [TestMethod]
            public void Should_get_a_result_of_60()
            {
                var problem = new KnapsackFileReader(@".\knapsack\knapsack_1_df02.txt").Read();
                var ks = new KnapsackIterativeSolver(problem);
                var result = ks.Execute();
                result.ShouldEqual(60);
            }
        }

        [TestClass]
        public class WhenUsingDf03
        {
            [TestMethod]
            public void Should_get_a_result_of_60()
            {
                var problem = new KnapsackFileReader(@".\knapsack\knapsack_1_df03.txt").Read();
                var ks = new KnapsackIterativeSolver(problem);
                var result = ks.Execute();
                result.ShouldEqual(60);
            }
        }

        [TestClass]
        public class WhenUsingDf04
        {
            [TestMethod]
            public void Should_get_a_result_of_27000()
            {
                var problem = new KnapsackFileReader(@".\knapsack\knapsack_1_df04.txt").Read();
                var ks = new KnapsackIterativeSolver(problem);
                var result = ks.Execute();
                result.ShouldEqual(27000);
            }
        }

        [TestClass]
        public class WhenUsingDf05
        {
            [TestMethod]
            public void Should_get_a_result_of_27000()
            {
                var problem = new KnapsackFileReader(@".\knapsack\knapsack_1_df05.txt").Read();
                var ks = new KnapsackIterativeSolver(problem);
                var result = ks.Execute();
                result.ShouldEqual(27000);
            }
        }

        [TestClass]
        public class WhenUsingDf06
        {
            [TestMethod]
            public void Should_get_a_result_of_27000()
            {
                var problem = new KnapsackFileReader(@".\knapsack\knapsack_1_df06.txt").Read();
                var ks = new KnapsackIterativeSolver(problem);
                var result = ks.Execute();
                result.ShouldEqual(27000);
            }
        }

        [TestClass]
        public class WhenUsingVl01
        {
            [TestMethod]
            public void Should_get_a_result_of_8()
            {
                var problem = new KnapsackFileReader(@".\knapsack\knapsack_1_vl01.txt").Read();
                var ks = new KnapsackIterativeSolver(problem);
                var result = ks.Execute();
                result.ShouldEqual(8);
            }
        }

        [TestClass]
        public class WhenUsingHw1
        {
            [TestMethod]
            public void Should_get_a_result_of_2493893()
            {
                var problem = new KnapsackFileReader(@".\knapsack\knapsack_1_hw.txt").Read();
                var ks = new KnapsackIterativeSolver(problem);
                var result = ks.Execute();
                result.ShouldEqual(2493893);
            }
        }
    }
}
