namespace DynamicAlgorithms
{
    public class KnapsackProblem
    {
        public int Size { get; private set; }
        public int ItemCount { get; private set; }
        public int[][] KnapsackItems { get; private set; }

        public KnapsackProblem(int size, int itemCount, int[][] knapsackItems)
        {
            Size = size;
            ItemCount = itemCount;
            KnapsackItems = knapsackItems;
        }
    }
}