
namespace SortingAlogrithms
{
    public class IntQuickSorter : ISorter<int[]>
    {
        private readonly IQuickSortPivotSelector _pivotSelector;

        public IntQuickSorter(IQuickSortPivotSelector pivotSelector)
        {
            _pivotSelector = pivotSelector;
        }

        public long CompareCount { get; private set; }

        public int[] Sort(int[] input)
        {
            Sort(input, 0, input.Length);
            return input;
        }

        private void Sort(int[] input, int start, int len)
        {
            //base case
            if (len <= 1) return;

            _pivotSelector.ChoosePivot(input, start, len);

            int pivotPosition = start;
            int pivotValue = input[pivotPosition];

            //partition
            for (int j = start + 1; j < start + len; j++)
            {
                ++CompareCount;
                if (input[j] < pivotValue)
                {
                    Swap(input, ++pivotPosition, j);
                }
            }
            
            Swap(input, start, pivotPosition);

            //work on sub problems
            //CompareCount += pivotPosition - start - 1;
            Sort(input, start, pivotPosition - start);

            //CompareCount += start + len - pivotPosition - 1 - 1;
            Sort(input, pivotPosition + 1, start + len - pivotPosition - 1);
        }

        private static void Swap(int[] input, int i, int j)
        {
            var tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }
    }
}