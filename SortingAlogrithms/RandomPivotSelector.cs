using System;

namespace SortingAlogrithms
{
    public class RandomPivotSelector : IQuickSortPivotSelector
    {
        private static readonly Random RandomPivot = new Random();

        public void ChoosePivot(int[] input, int start, int len)
        {
            int position = RandomPivot.Next(start, start + len);
            Swap(input, start, position);
        }

        private static void Swap(int[] input, int i, int j)
        {
            var tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }
    }
}