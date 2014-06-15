using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlogrithms;

namespace SortingAlgorithmsTests
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void Should_sort_elements()
        {
            new IntInsertionSorter().Should_sort_elements();
        }

        [TestMethod]
        public void Should_sort_1_element()
        {
            new IntInsertionSorter().Should_sort_1_element();
        }

        [TestMethod]
        public void Should_sort_even_elements()
        {
            new IntInsertionSorter().Should_sort_even_elements();
        }

        [TestMethod]
        public void Should_sort_odd_elements()
        {
            new IntInsertionSorter().Should_sort_odd_elements();
        }

        [TestMethod]
        public void Should_sort_backwards_elements()
        {
            new IntInsertionSorter().Should_sort_backwards_elements();
        }

        //input too large...current takes 29 seconds??
        //[TestMethod]
        //public void Should_sort_week_1_assignment()
        //{
        //    new IntInsertionSorter().Should_sort_week_1_assignment();
        //}

        [TestMethod]
        public void Should_sort_week_2_assignment()
        {
            new IntInsertionSorter().Should_sort_week_2_assignment();
        }

        [TestMethod]
        public void Should_sort_week1_discussion_forum_01()
        {
            new IntInsertionSorter().Should_sort_week1_discussion_forum_01();
        }

        [TestMethod]
        public void Should_sort_week1_discussion_forum_02()
        {
            new IntInsertionSorter().Should_sort_week1_discussion_forum_02();
        }

        [TestMethod]
        public void Should_sort_mit_l04_example()
        {
            new IntInsertionSorter().Should_sort_mit_l04_example();
        }
    }
}