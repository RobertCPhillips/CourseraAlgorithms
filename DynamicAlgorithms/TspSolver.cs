using System;

namespace DynamicAlgorithms
{
    public class TspSolver
    {
        private const int StartingPointIndex = 1;

        private readonly double[][] _points;
        private readonly TspPathBitArrayGenerator _generator;
        private readonly double[] _startingPoint;

        public TspSolver(double[][] points)
        {
            _points = points;
            _startingPoint = points[StartingPointIndex - 1]; //-1 since arrays are 0 based
            _generator = new TspPathBitArrayGenerator();
        }

        public int Execute()
        {
            var n = _points.Length;
            var size = (int) Math.Pow(2, n);

            var table = new double[size][];
            table[StartingPointIndex] = GetColumn(StartingPointIndex, n);

            for (var m = 2; m <= n; m++)
            {
                var pathsOfSizeM = _generator.Generate(n, m);

                var currentTable = new double[size][];
                foreach (var path in pathsOfSizeM)
                {
                    currentTable[path] = GetColumn(path, n);

                    for (var j = 1; j < n; j++) //j starts at 1 since array is 0 based
                    {
                        var jShift = 1 << j;
                        if ((path & jShift) != jShift) continue; //j not in path

                        var pathWithoutJ = path & (Int32.MaxValue ^ jShift);
                        currentTable[path][j] = Min(table[pathWithoutJ], path, j, n);
                    }
                }

                table = currentTable;
            }

            var fullPath = _generator.Generate(n, n)[0];

            var allCovered = table[fullPath];
            double result = int.MaxValue;

            for (var j = 1; j < n; j++) //j starts at 1 since array is 0 based
            {
                var min = allCovered[j] + Cost(_points[j], _startingPoint);
                if (min < result) result = min;
            }

            var rounded = Math.Floor(result);
            return Convert.ToInt32(rounded);
        }

        private double Min(double[] table, int path, int j, int n)
        {
            double result = Int32.MaxValue;

            for (var k = 0; k < n; k++)
            {
                if (j == k) continue;

                var kShift = 1 << k;
                if ((path & kShift) != kShift) continue; //k not in path

                var min = table[k] + Cost(_points[k], _points[j]);

                if (min < result) result = min;
            }

            return result;
        }

        private static double[] GetColumn(int path, int n)
        {
            var column = new double[n];
            if (path == StartingPointIndex) column[0] = 0; //+1 since arrays are 0 based
            else column[0] = int.MaxValue;

            return column;
        }

        private static double Cost(double[] p1, double[] p2)
        {
            return Math.Sqrt(Math.Pow(p1[0] - p2[0], 2) + Math.Pow(p1[1] - p2[1], 2));
        }
    }
}