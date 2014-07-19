using DynamicAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace DynamicAlgorithmTests
{
    public class WhenCalculatingKnapsackOptimized
    {
        [TestClass]
        public class WhenUsingDf01
        {
            [TestMethod]
            public void Should_get_a_result_of_4125332()
            {
                var problem = new KnapsackFileReader(@".\knapsack\knapsack_2_df01.txt").Read();
                var ks = new KnapsackOptimizedSolver(problem);
                var result = ks.Execute();
                result.ShouldEqual(4125332);
            }
        }


        [TestClass]
        public class WhenUsingDf02
        {
            [TestMethod]
            public void Should_get_a_result_of_2791685()
            {
                var problem = new KnapsackFileReader(@".\knapsack\knapsack_2_df02.txt").Read();
                var ks = new KnapsackOptimizedSolver(problem);
                var result = ks.Execute();
                result.ShouldEqual(2791685);
            }
        }

        [TestClass]
        public class WhenUsingDf03
        {
            [TestMethod]
            public void Should_get_a_result_of_3067036()
            {
                var problem = new KnapsackFileReader(@".\knapsack\knapsack_2_df03.txt").Read();
                var ks = new KnapsackOptimizedSolver(problem);
                var result = ks.Execute();
                result.ShouldEqual(3067036);
            }
        }

        [TestClass]
        public class WhenUsingHw2
        {
            [TestMethod]
            public void Should_get_a_result_of_4243395()
            {
                var problem = new KnapsackFileReader(@".\knapsack\knapsack_2_hw.txt").Read();
                var ks = new KnapsackOptimizedSolver(problem);
                var result = ks.Execute();
                result.ShouldEqual(4243395);
            }
        }
    }
}