using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DynamicAlgorithms
{
    public class TspPathBitArrayGenerator
    {
        public int[] Generate(int n, int m)
        {
            var pathCount = GetBinCoeff(n - 1, m - 1);
            var bitPaths = new List<int>(pathCount);

            var buffer = new int[32];
            Combine(0, 0, n, m, buffer, bitPaths);

            return bitPaths.ToArray();
        }

        //from discussion forum
        private static void Combine(int depth, int index, int n, int m, int[] buffer, ICollection<int> paths)
        {
            if (depth > m - 1)
            {
                var num = 0;

                for (var j = 0; j < m; j++)
                {
                    num = num | (1 << (buffer[j] - 1));
                }
                if ((num & 1) == 1)
                {
                    Debug.WriteLine(num);
                    paths.Add(num);
                }
            }
            else
            {
                for (int p = index; p < n - m + 1 + depth; p++)
                {
                    buffer[depth] = p + 1;
                    Combine(depth + 1, p + 1, n, m, buffer, paths);
                }
            }
        }

        //from:  http://blog.plover.com/math/choose.html
        private static int GetBinCoeff(int n, int k)
        {
            var r = 1;
            int d;
            if (k > n) return 0;
            for (d = 1; d <= k; d++)
            {
                r *= n--;
                r /= d;
            }
            return r;
        }
    }
}