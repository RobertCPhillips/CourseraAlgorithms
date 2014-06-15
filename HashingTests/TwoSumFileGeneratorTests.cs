using System.IO;
using Hashing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace HashingTests
{
    public class TwoSumFileGeneratorTests
    {
        [TestClass]
        public class WhenBuildingFiles
        {
            //foreach (var i in new[] { 20, 100, 1000, 10000, 100000, 1000000 })
            private TwoSumFileGenerator _generator;

            [TestInitialize]
            public void Init()
            {
                _generator = new TwoSumFileGenerator();                
            }

            [TestMethod]
            public void Should_build_a_file_with_20_lines()
            {
                var file = _generator.Generate(20);
                File.Exists(file).ShouldBeTrue();
                File.ReadAllLines(file).Length.ShouldEqual(20);
            }

            [TestMethod]
            public void Should_build_a_file_with_100_lines()
            {
                var file = _generator.Generate(100);
                File.Exists(file).ShouldBeTrue();
                File.ReadAllLines(file).Length.ShouldEqual(100);
            }

            [TestMethod]
            public void Should_build_a_file_with_1000_lines()
            {
                var file = _generator.Generate(1000);
                File.Exists(file).ShouldBeTrue();
                File.ReadAllLines(file).Length.ShouldEqual(1000);
            }

            [TestMethod]
            public void Should_build_a_file_with_10000_lines()
            {
                var file = _generator.Generate(10000);
                File.Exists(file).ShouldBeTrue();
                File.ReadAllLines(file).Length.ShouldEqual(10000);
            }
        }
    }
}