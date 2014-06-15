namespace SortingAlogrithms
{
    public class IntInsertionSorter : ISorter<int[]>
    {
        public int[] Sort(int[] input)
        {
            if (input.Length == 1) return input;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < input[i - 1])
                {
                    for (int j = i; j > 0; j--)
                    {
                        if (input[j] < input[j - 1])
                        {
                            int tmp = input[j];
                            input[j] = input[j - 1];
                            input[j - 1] = tmp;
                        }
                        else
                        {
                            break;
                        }
                    } 
                }
            }
            return input;
        }
    }
}