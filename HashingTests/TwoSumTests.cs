using System;
using Hashing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace HashingTests
{
    public class TwoSumTests
    {
        [TestClass]
        public class WhenUsingTheHwList
        {
            [TestMethod]
            public void Should_return_427()
            {
                //arrange
                var twoSum = new TwoSum("algo1_programming_prob_2sum.txt");

                //act
                var result = twoSum.Execute();

                //assert
                result.ShouldEqual(427);
            }

            [TestMethod]
            public void Should_return_257()
            {
                //arrange
                var twoSum = new TwoSum("algo1_programming_prob_2sum_sub.txt");

                //act
                var result = twoSum.Execute();

                //assert
                result.ShouldEqual(257);
            }
        }

        [TestClass]
        public class WhenUsingTheDf20File
        {
            [TestMethod]
            public void Should_get_1()
            {
                //arrange
                var twoSum = new TwoSum("sum2tc_20.txt");

                //act
                var result = twoSum.Execute();

                //assert
                result.ShouldEqual(1);
            }
        }

        [TestClass]
        public class WhenUsingTheDf100File
        {
            [TestMethod]
            public void Should_get_6()
            {
                //arrange
                var twoSum = new TwoSum("sum2tc_100.txt");

                //act
                var result = twoSum.Execute();

                //assert
                result.ShouldEqual(6);
            }
        }

        [TestClass]
        public class WhenUsingTheDf1000File
        {
            [TestMethod]
            public void Should_get_609()
            {
                //arrange
                var twoSum = new TwoSum("sum2tc_1000.txt");

                //act
                var result = twoSum.Execute();

                //assert
                result.ShouldEqual(609);
            }
        }

        [TestClass]
        public class WhenUsingTheDf10000File
        {
            [TestMethod]
            public void Should_get_19017()
            {
                //arrange
                var twoSum = new TwoSum("sum2tc_10000.txt");

                //act
                var result = twoSum.Execute();

                //assert
                result.ShouldEqual(19017);
            }
        }
    }
}
