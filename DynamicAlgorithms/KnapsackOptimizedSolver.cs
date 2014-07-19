namespace DynamicAlgorithms
{
    public class KnapsackOptimizedSolver
    {
        private readonly KnapsackProblem _problem;

        public KnapsackOptimizedSolver(KnapsackProblem problem)
        {
            _problem = problem;
        }

        public int Execute()
        {
            var size = _problem.Size;
            var itemCount = _problem.ItemCount;

            var column = new int[size + 1] ;

            var knapsackItems = _problem.KnapsackItems;

            for (var i = 1; i <= itemCount; i++)
            {
                var temp = new int[size + 1];
                for (var x = 0; x <= size; x++)
                {
                    temp[x] = Max(column, i, x, knapsackItems[i]);
                }
                column = temp;
            }

            return column[size];
        }

        private static int Max(int[] previousColumn, int i, int x, int[] knapsackItem)
        {
            var case1 = previousColumn[x];
            var vi = knapsackItem[0];
            var wi = knapsackItem[1];

            if (wi > x) return case1;

            var case2 = previousColumn[x - wi] + vi;

            return case1 >= case2 ? case1 : case2;
        }

    }
}