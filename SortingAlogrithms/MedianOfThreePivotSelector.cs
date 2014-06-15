namespace SortingAlogrithms
{
    public class MedianOfThreePivotSelector : IQuickSortPivotSelector
    {
        public void ChoosePivot(int[] input, int start, int len)
        {
            int firstIndex = start;
            int first = input[firstIndex];

            int lastIndex = start + len - 1;
            int last = input[lastIndex];
            
            int middleIndex = start + (len/2);
            if (len % 2 == 0) --middleIndex;
            int middle = input[middleIndex];

            //first is largest
            if (first > middle && first > last)
            {
                if (middle > last) Swap(input, start, middleIndex);
                else Swap(input, start, lastIndex);
            }
                //middle is largest
            else if (middle > first && middle > last)
            {
                if (first > last) Swap(input, start, firstIndex);
                else Swap(input, start, lastIndex);
            }
                //last is largest
            else if (last > first && last > middle)
            {
                if (middle > first) Swap(input, start, middleIndex);
                else Swap(input, start, firstIndex);
            }

            //EXAMPLE: For the input array 8 2 4 5 7 1 you would consider the first (8), middle (4), 
            //and last (1) elements; 
            //since 4 is the median of the set {1,4,8}, you would use 4 as your pivot element. 

            //(If the array has odd length it should be clear what the "middle" element is; 
            //for an array with even length 2k, use the k element as the "middle" element. 
            //So for the array 4 5 6 7, the "middle" element is the second one ---- 5 and not 6!)
        }

        private static void Swap(int[] input, int i, int j)
        {
            var tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }
    }
}