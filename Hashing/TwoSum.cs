using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hashing
{
    public class TwoSum
    {
        private readonly string _file;

        private const Int64 IntervalStart = -10000;
        private const Int64 IntervalEnd = 10000;

        public TwoSum(string file)
        {
            _file = file;
        }

        public int Execute()
        {
            var fileItems = File.ReadAllLines(_file).Select(Int64.Parse).ToArray();
            var hashSet = new HashSet<Int64>(fileItems);
            var result = new ConcurrentBag<Int64>();

            Parallel.ForEach(fileItems, x =>
            {
                var y1 = IntervalStart - x;
                var y2 = IntervalEnd - x;

                for (var y = y1; y <= y2; y++)
                {
                    if (hashSet.Contains(y))
                        result.Add(x + y);
                }
            });

            return result.Distinct().Count();
        }
    }
}
