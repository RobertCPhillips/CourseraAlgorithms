using System;
using System.Linq;

namespace SortingAlogrithms
{
    public class IntMergeSorter : ISorter<int[]>
    {
        public int[] Sort(int[] input)
        {
            if (input.Length == 1) return input;

            var firstLength = input.Length / 2;
            var secondLength = input.Length - firstLength;

            var first = new int[firstLength];
            var second = new int[secondLength];
            Array.Copy(input, first, firstLength);
            Array.Copy(input, firstLength, second, 0, secondLength);

            var sortedFirst = Sort(first);
            var sortedSecond = Sort(second);

            return Merge(sortedFirst, sortedSecond);
        }

        private static int[] Merge(int[] sortedFirst, int[] sortedSecond)
        {
            var result = new int[sortedFirst.Length + sortedSecond.Length];

            int firstIndex = 0;
            int secondIndex = 0;

            for (var k = 0; k < result.Length; k++)
            {
                if (firstIndex == sortedFirst.Length)
                {
                    result[k] = sortedSecond[secondIndex];
                    ++secondIndex;
                }
                else if (secondIndex == sortedSecond.Length)
                {
                    result[k] = sortedFirst[firstIndex];
                    ++firstIndex;
                }
                else if (sortedFirst[firstIndex] < sortedSecond[secondIndex])
                {
                    result[k] = sortedFirst[firstIndex];
                    ++firstIndex;
                }
                else if (sortedFirst[firstIndex] > sortedSecond[secondIndex])
                {
                    result[k] = sortedSecond[secondIndex];
                    ++secondIndex;
                }
            }

            return result;
        }
    }
}