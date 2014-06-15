using Hashing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace HashingTests
{
    [TestClass]
    public class MedianMaintTests
    {
        [TestMethod]
        public void Should_get_hw_result()
        {
            var m = new MedianMaint("MedianHw.txt");
            var result = m.Execute();
            result.ShouldBeGreaterThan(0);
        }

        [TestMethod]
        public void Should_get_3()
        {
            var m = new MedianMaint("MediaDf_3.txt");
            var result = m.Execute();
            result.ShouldEqual(3);
        }

        [TestMethod]
        public void Should_get_5()
        {
            var m = new MedianMaint("MediaDf_5.txt");
            var result = m.Execute();
            result.ShouldEqual(5);
        }

        [TestMethod]
        public void Should_get_23()
        {
            var m = new MedianMaint("MediaDf_23.txt");
            var result = m.Execute();
            result.ShouldEqual(23);
        }

        [TestMethod]
        public void Should_get_54()
        {
            var m = new MedianMaint("MediaDf_54.txt");
            var result = m.Execute();
            result.ShouldEqual(54);
        }

        [TestMethod]
        public void Should_get_55()
        {
            var m = new MedianMaint("MediaDf_55.txt");
            var result = m.Execute();
            result.ShouldEqual(55);
        }

        [TestMethod]
        public void Should_get_82()
        {
            var m = new MedianMaint("MediaDf_82.txt");
            var result = m.Execute();
            result.ShouldEqual(82);
        }

        [TestMethod]
        public void Should_get_148()
        {
            var m = new MedianMaint("MediaDf_148.txt");
            var result = m.Execute();
            result.ShouldEqual(148);
        }
    }
}