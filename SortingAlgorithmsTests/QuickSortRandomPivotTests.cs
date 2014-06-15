﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlogrithms;

namespace SortingAlgorithmsTests
{
    [TestClass]
    public class QuickSortRandomPivotTests
    {
        private IntQuickSorter _sorter;

        [TestInitialize]
        public void TestInit()
        {
            _sorter = new IntQuickSorter(new RandomPivotSelector());
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