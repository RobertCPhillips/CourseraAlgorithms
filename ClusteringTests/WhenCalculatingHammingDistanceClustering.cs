using GraphAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace ClusteringTests
{
    public class WhenCalculatingHammingDistanceClustering
    {
        //The correct answer is a 4-digit number.

        [TestClass]
        public class WhenUsingPointsInDf01
        {
            [TestMethod]
            public void Should_have_1_cluster()
            {
                var calculator = new HammingDistanceClustering("clustering_2_df1.txt");
                var result = calculator.Calculate();
                result.ShouldEqual(1);
            }
        }

        [TestClass]
        public class WhenUsingPointsInDf02
        {
            [TestMethod]
            public void Should_have_3_clusters()
            {
                var calculator = new HammingDistanceClustering("clustering_2_df2.txt");
                var result = calculator.Calculate();
                result.ShouldEqual(3);
            }
        }

        [TestClass]
        public class WhenUsingPointsInDf03
        {
            [TestMethod]
            public void Should_have_4_clusters()
            {
                var calculator = new HammingDistanceClustering("clustering_2_df3.txt");
                var result = calculator.Calculate();
                result.ShouldEqual(4);
            }
        }

        [TestClass]
        public class WhenUsingPointsInDf04
        {
            [TestMethod]
            public void Should_have_11_clusters()
            {
                var calculator = new HammingDistanceClustering("clustering_2_df4.txt");
                var result = calculator.Calculate();
                result.ShouldEqual(11);
            }
        }

        [TestClass]
        public class WhenUsingPointsInDf05
        {
            [TestMethod]
            public void Should_have_1_cluster()
            {
                var calculator = new HammingDistanceClustering("clustering_2_df5.txt");
                var result = calculator.Calculate();
                result.ShouldEqual(1);
            }
        }

        [TestClass]
        public class WhenUsingPointsInDf06
        {
            [TestMethod]
            public void Should_have_1_cluster()
            {
                var calculator = new HammingDistanceClustering("clustering_2_df6.txt");
                var result = calculator.Calculate();
                result.ShouldEqual(1);
            }
        }

        [TestClass]
        public class WhenUsingPointsInDf07
        {
            [TestMethod]
            public void Should_have_2_clusters()
            {
                var calculator = new HammingDistanceClustering("clustering_2_df7.txt");
                var result = calculator.Calculate();
                result.ShouldEqual(2);
            }
        }

        [TestClass]
        public class WhenUsingPointsInDf08
        {
            [TestMethod]
            public void Should_have_497_clusters()
            {
                var calculator = new HammingDistanceClustering("clustering_2_df8.txt");
                var result = calculator.Calculate();
                result.ShouldEqual(497);
            }
        }

        [TestClass]
        public class WhenUsingPointsInDf09
        {
            [TestMethod]
            public void Should_have_989_clusters()
            {
                var calculator = new HammingDistanceClustering("clustering_2_df9.txt");
                var result = calculator.Calculate();
                result.ShouldEqual(989);
            }
        }

        [TestClass]
        public class WhenUsingPointsInDf10
        {
            [TestMethod]
            public void Should_have_2_clusters()
            {
                var calculator = new HammingDistanceClustering("clustering_2_df10.txt");
                var result = calculator.Calculate();
                result.ShouldEqual(2);
            }
        }
        [TestClass]
        public class WhenUsingPointsInDf11
        {
            [TestMethod]
            public void Should_have_9116_clusters()
            {
                var calculator = new HammingDistanceClustering("clustering_2_df11.txt");
                var result = calculator.Calculate();
                result.ShouldEqual(9116);
            }
        }

        [TestClass]
        public class WhenUsingPointsInHw
        {
            [TestMethod]
            public void Should_have_6118_clusters()
            {
                var calculator = new HammingDistanceClustering("clustering_2_hw.txt");
                var result = calculator.Calculate();
                result.ShouldEqual(6118);
            }
        }
    }
}