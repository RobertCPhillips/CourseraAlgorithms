namespace DynamicAlgorithms
{
    public class KnapsackIterativeSolver
    {
        private readonly KnapsackProblem _problem;

        public KnapsackIterativeSolver(KnapsackProblem problem)
        {
            _problem = problem;
        }

        public int Execute()
        {
            var size = _problem.Size;
            var itemCount = _problem.ItemCount;

            var table = new int[itemCount + 1][];
            table[0] = new int[size + 1];

            var knapsackItems = _problem.KnapsackItems;

            for (var ki = 1; ki <= itemCount; ki++)
            {
                table[ki] = new int[size + 1];
            }

            for (var i = 1; i <= itemCount; i++)
            {
                for (var x = 0; x <= size; x++)
                {
                    table[i][x] = Max(table, i, x, knapsackItems[i]);
                }
            }

            return table[itemCount][size];
        }

        private static int Max(int[][] table, int i, int x, int[] knapsackItem)
        {
            var case1 = table[i - 1][x];
            var vi = knapsackItem[0];
            var wi = knapsackItem[1];

            if (wi > x) return case1;

            var case2 = table[i - 1][x - wi] + vi;

            return case1 >= case2 ? case1 : case2;
        }
    }
}
