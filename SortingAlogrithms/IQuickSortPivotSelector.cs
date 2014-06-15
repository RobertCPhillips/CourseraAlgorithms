namespace SortingAlogrithms
{
    public interface IQuickSortPivotSelector
    {
        void ChoosePivot(int[] input, int start, int len);
    }
}