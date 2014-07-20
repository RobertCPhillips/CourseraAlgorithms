using System.Linq;

namespace DynamicAlgorithms
{
    public class OptimalBstIterativeSolver
    {
        private readonly double[][] _keys;

        public OptimalBstIterativeSolver(double[][] keys)
        {
            _keys = keys;
        }

        public double Solve()
        {
            var n = _keys.Length;

            var table = new double[n + 1][];
            for (var ki = 0; ki <= n; ki++)
            {
                table[ki] = new double[n + 1];
            }

            for (var s = 0; s <= (n - 1); s++)
            {
                //for (var i = 1; i <= n; i++)
                for (var i = 1; i <= n-s; i++)
                {
                    var j = i + s;
                    table[i][j] = Min(table, i, j);
                }
            }

            return table[1][n];
        }

        private double Min(double[][] table, int i, int j)
        {
            var min = double.MaxValue;

            for (var r = i; r <= j; r++)
            {
                var temp = WeightSum(i, j);
                temp += i > (r - 1) ? 0 : table[i][r - 1];
                temp += (r + 1) > j ? 0 : table[r + 1][j];

                if (temp < min)
                {
                    min = temp;
                }
            }

            return min;
        }

        private double WeightSum(int i, int j)
        {
            var sum = _keys.Skip(i-1).Take(j-i+1).Sum(k => k[1]);
            return sum;
        }
    }
}
