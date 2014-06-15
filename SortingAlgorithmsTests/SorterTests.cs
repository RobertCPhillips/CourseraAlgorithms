using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlogrithms;

namespace SortingAlgorithmsTests
{
    public static class SorterTests
    {
        public static void Should_sort_elements(this ISorter<int[]> sorter)
        {
            //arrange
            var inputArray01 = new[] { 2, 4, 6, 8, 9, 7, 5, 3, 1, 0, 11, 34, 21, 5555, 322 };

            //act
            var result = sorter.Sort(inputArray01);

            //assert
            CollectionAssert.AreEqual(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 21, 34, 322, 5555 }, result);
        }

        public static void Should_sort_1_element(this ISorter<int[]> sorter)
        {
            //arrange
            var inputArray01 = new[] { 1 };

            //act
            var result = sorter.Sort(inputArray01);

            //assert
            CollectionAssert.AreEqual(new[] { 1 }, result);
        }

        public static void Should_sort_even_elements(this ISorter<int[]> sorter)
        {
            //arrange
            var inputArray01 = new[] { 2, 1 };

            //act
            var result = sorter.Sort(inputArray01);

            //assert
            CollectionAssert.AreEqual(new[] { 1, 2 }, result);
        }

        public static void Should_sort_odd_elements(this ISorter<int[]> sorter)
        {
            //arrange
            var inputArray01 = new[] { 9, 1, 2 };

            //act
            var result = sorter.Sort(inputArray01);

            //assert
            CollectionAssert.AreEqual(new[] { 1, 2, 9 }, result);
        }

        public static void Should_sort_backwards_elements(this ISorter<int[]> sorter)
        {
            //arrange
            var inputArray01 = new[] { 6, 5, 4, 3, 2, 1 };

            //act
            var result = sorter.Sort(inputArray01);

            //assert
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6 }, result);
        }

        public static void Should_sort_week_1_assignment(this ISorter<int[]> sorter)
        {
            //arrange
            var fileItems = System.IO.File.ReadAllLines("integerarray.txt");
            var inputArray01 = fileItems.Select(Int32.Parse).ToArray();
            var inputArray01Ordered = inputArray01.OrderBy(x => x).ToArray();

            //act
            var result = sorter.Sort(inputArray01);

            //assert
            CollectionAssert.AreEqual(inputArray01Ordered, result);
        }

        public static void Should_sort_week_2_assignment(this ISorter<int[]> sorter)
        {
            //arrange
            var fileItems = System.IO.File.ReadAllLines("quicksort.txt");
            var inputArray01 = fileItems.Select(Int32.Parse).ToArray();
            var inputArray01Ordered = inputArray01.OrderBy(x => x).ToArray();

            //act
            var result = sorter.Sort(inputArray01);

            //assert
            CollectionAssert.AreEqual(inputArray01Ordered, result);
        }

        public static void Should_sort_week_2_discussion_forum_10(this ISorter<int[]> sorter)
        {
            //arrange
            var fileItems = System.IO.File.ReadAllLines("quicksort10.txt");
            var inputArray01 = fileItems.Select(Int32.Parse).ToArray();
            var inputArray01Ordered = inputArray01.OrderBy(x => x).ToArray();

            //act
            var result = sorter.Sort(inputArray01);

            //assert
            CollectionAssert.AreEqual(inputArray01Ordered, result);
        }

        public static void Should_sort_week_2_discussion_forum_100(this ISorter<int[]> sorter)
        {
            //arrange
            var fileItems = System.IO.File.ReadAllLines("quicksort100.txt");
            var inputArray01 = fileItems.Select(Int32.Parse).ToArray();
            var inputArray01Ordered = inputArray01.OrderBy(x => x).ToArray();

            //act
            var result = sorter.Sort(inputArray01);

            //assert
            CollectionAssert.AreEqual(inputArray01Ordered, result);
        }

        public static void Should_sort_week_2_discussion_forum_1000(this ISorter<int[]> sorter)
        {
            //arrange
            var fileItems = System.IO.File.ReadAllLines("quicksort1000.txt");
            var inputArray01 = fileItems.Select(Int32.Parse).ToArray();
            var inputArray01Ordered = inputArray01.OrderBy(x => x).ToArray();

            //act
            var result = sorter.Sort(inputArray01);

            //assert
            CollectionAssert.AreEqual(inputArray01Ordered, result);
        }

        public static void Should_sort_week_2_discussion_forum_01(this ISorter<int[]> sorter)
        {
            //arange
            var inputArray01 = new[]
            {
                2, 5, 4, 3, 0, 9, 8, 6, 1, 20, 17
            };
            var inputArray01Ordered = inputArray01.OrderBy(x => x).ToArray();

            //act
            var result = sorter.Sort(inputArray01);

            //assert
            CollectionAssert.AreEqual(inputArray01Ordered, result);
        }

        public static void Should_sort_week1_discussion_forum_01(this ISorter<int[]> sorter)
        {
            //arange
            var inputArray01 = new[]
            {
                4, 80, 70, 23, 9, 60, 68, 27, 66, 78, 12, 40, 52, 53, 44, 8, 49, 28, 18, 46, 21, 39, 51, 7, 87, 99, 69,
                62, 84, 6, 79, 67, 14, 98, 83, 0, 96, 5, 82, 10, 26, 48, 3, 2, 15, 92, 11, 55, 63, 97, 43, 45, 81,
                42, 95, 20, 25, 74, 24, 72, 91, 35, 86, 19, 75, 58, 71, 47, 76, 59, 64, 93, 17, 50, 56, 94, 90, 89,
                32, 37, 34, 65, 1, 73, 41, 36, 57, 77, 30, 22, 13, 29, 38, 16, 88, 61, 31, 85, 33, 54
            };
            var inputArray01Ordered = inputArray01.OrderBy(x => x).ToArray();

            //act
            var result = sorter.Sort(inputArray01);

            //assert
            CollectionAssert.AreEqual(inputArray01Ordered, result);
        }

        public static void Should_sort_week1_discussion_forum_02(this ISorter<int[]> sorter)
        {
            //arrange
            var inputArray01 = new[]
            {
                37, 7, 2, 14, 35, 47, 10, 24, 44, 17, 34, 11, 16, 48, 1, 39, 6, 33, 43, 26, 40, 4, 28, 5, 38, 41, 42,
                12, 13, 21, 29, 18, 3, 19, 0, 32, 46, 27, 31, 25, 15, 36, 20, 8, 9, 49, 22, 23, 30, 45
            };
            var inputArray01Ordered = inputArray01.OrderBy(x => x).ToArray();

            //act
            var result = sorter.Sort(inputArray01);

            //assert
            CollectionAssert.AreEqual(inputArray01Ordered, result);
        }

        public static void Should_sort_mit_l04_example(this ISorter<int[]> sorter)
        {
            //arrange
            var inputArray01 = new[] { 6, 10, 13, 5, 8, 3, 2, 11 };
            var inputArray01Ordered = inputArray01.OrderBy(x => x).ToArray();

            //act
            var result = sorter.Sort(inputArray01);

            //assert
            CollectionAssert.AreEqual(inputArray01Ordered, result);
        }
    }
}