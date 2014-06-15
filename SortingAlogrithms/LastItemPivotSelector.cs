namespace SortingAlogrithms
{
    public class LastItemPivotSelector : IQuickSortPivotSelector
    {
        public void ChoosePivot(int[] input, int start, int len)
        {
            int position = start + len - 1;
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