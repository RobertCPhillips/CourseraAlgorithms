using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using SortingAlogrithms;

namespace SortingAlgorithmsTests
{
    [TestClass]
    public class QuickSortLastItemPivotTests
    {
        private IntQuickSorter _sorter;

        [TestInitialize]
        public void TestInit()
        {
            _sorter = new IntQuickSorter(new LastItemPivotSelector());
        }

        [TestMethod]
        public void Should_sort_elements()
        {
            _sorter.Should_sort_elements();
        }

        [TestMethod]
        public void Should_sort_1_element()
        {
            _sorter.Should_sort_1_element();
        }

        [TestMethod]
        public void Should_sort_even_elements()
        {
            _sorter.Should_sort_even_elements();
        }

        [TestMethod]
        public void Should_sort_odd_elements()
        {
            _sorter.Should_sort_odd_elements();
        }

        [TestMethod]
        public void Should_sort_backwards_elements()
        {
            _sorter.Should_sort_backwards_elements();
        }

        [TestMethod]
        public void Should_sort_week_1_assignment()
        {
            _sorter.Should_sort_week_1_assignment();
        }

        [TestMethod]
        public void Should_sort_week_2_assignment()
        {
            _sorter.Should_sort_week_2_assignment();
        }

        [TestMethod]
        public void Should_sort_week_2_discussion_forum_01()
        {
            _sorter.Should_sort_week_2_discussion_forum_01();
            var result = _sorter.CompareCount;

            result.ShouldEqual(35);
        }

        [TestMethod]
        public void Should_sort_week_2_discussion_forum_10()
        {
            _sorter.Should_sort_week_2_discussion_forum_10();
            var result = _sorter.CompareCount;

            result.ShouldEqual(29);
        }

        [TestMethod]
        public void Should_sort_week_2_discussion_forum_100()
        {
            _sorter.Should_sort_week_2_discussion_forum_100();
            var result = _sorter.CompareCount;

            result.ShouldEqual(587);
        }

        [TestMethod]
        public void Should_sort_week_2_discussion_forum_1000()
        {
            _sorter.Should_sort_week_2_discussion_forum_1000();
            var result = _sorter.CompareCount;

            result.ShouldEqual(10184);
        }

        [TestMethod]
        public void Should_sort_week1_discussion_forum_01()
        {
            _sorter.Should_sort_week1_discussion_forum_01();
        }

        [TestMethod]
        public void Should_sort_week1_discussion_forum_02()
        {
            _sorter.Should_sort_week1_discussion_forum_02();
        }

        [TestMethod]
        public void Should_sort_mit_l04_example()
        {
            _sorter.Should_sort_mit_l04_example();
        }
    }
}