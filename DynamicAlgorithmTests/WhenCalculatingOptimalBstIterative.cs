using System;
using DynamicAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace DynamicAlgorithmTests
{
    public class WhenCalculatingOptimalBstIterative
    {
        [TestClass]
        public class WhenUsingPs
        {
            [TestMethod]
            public void The_result_should_be_2_point_18()
            {
                var input = new[]
                {
                    new[]{1, .05},
                    new[]{2, .4},
                    new[]{3, .08},
                    new[]{4, .04},
                    new[]{5, .1},
                    new[]{6, .1},
                    new[]{7, .23}
                };

                var solver = new OptimalBstIterativeSolver(input);
                var result = Math.Round(solver.Solve(), 2);
                result.ShouldEqual(2.18);
            }
        }

        [TestClass]
        public class WhenUsingVl01
        {
            [TestMethod]
            public void The_result_should_be_1_point_3()
            {
                var input = new[]
                {
                    new[]{1, .8},
                    new[]{2, .1},
                    new[]{3, .1}
                };

                var solver = new OptimalBstIterativeSolver(input);
                var result = solver.Solve();
                result.ShouldEqual(1.3);
            }
        }

        [TestClass]
        public class WhenUsingOneItem
        {
            [TestMethod]
            public void Should_return_the_item()
            {
                var input = new[] {new[] {1, 1.0}};

                var solver = new OptimalBstIterativeSolver(input);
                var result = solver.Solve();
                result.ShouldEqual(1.0);
            }
        }

        [TestClass]
        public class WhenUsingTwoItems
        {
            [TestMethod]
            public void Should_return_the_larger_item_plus_2_times_smaller_item()
            {
                var input = new[]
                {
                    new[] { 1, .8 },
                    new[] { 2, .2 }
                };

                var solver = new OptimalBstIterativeSolver(input);
                var result = solver.Solve();
                result.ShouldEqual(1.2);
            }
        }

        [TestClass]
        public class WhenUsingExame
        {
            [TestMethod]
            public void Should_calcuate_the_answer()
            {
                var input = new[]
                {
                    new[] { 1, .2 },
                    new[] { 2, .05 },
                    new[] { 3, .17 },
                    new[] { 4, .1 },
                    new[] { 5, .2 },
                    new[] { 6, .03 },
                    new[] { 7, .25 }
                };

                var solver = new OptimalBstIterativeSolver(input);
                var result = solver.Solve();
                result.ShouldEqual(2.23);
            }
        }
    }
}
