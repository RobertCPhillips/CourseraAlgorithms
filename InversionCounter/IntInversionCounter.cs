using System.Linq;

namespace InversionCounter
{
    public class IntInversionCounter : ICounter<int[]>
    {
        private long _counter;

        public long Count(int[] input)
        {
            if (input.Length == 1) return 0;
            Sort(input);
            return _counter;
        }

        private int[] Sort(int[] input)
        {
            if (input.Length == 1) return input;

            var halfSize = input.Length / 2;
            var first = input.Take(halfSize).ToArray();
            var second = input.Skip(halfSize).Take(input.Length - halfSize).ToArray();

            var sortedFirst = Sort(first);
            var sortedSecond = Sort(second);

            return Merge(sortedFirst, sortedSecond);
        }

        private int[] Merge(int[] sortedFirst, int[] sortedSecond)
        {
            var result = new int[sortedFirst.Length + sortedSecond.Length];

            int firstIndex = 0;
            int secondIndex = 0;

            for (var k = 0; k < result.Length; k++)
            {
                if (firstIndex == sortedFirst.Length)
                {
                    result[k] = sortedSecond[secondIndex];
                    ++secondIndex;
                }
                else if (secondIndex == sortedSecond.Length)
                {
                    result[k] = sortedFirst[firstIndex];
                    ++firstIndex;
                }
                else if (sortedFirst[firstIndex] < sortedSecond[secondIndex])
                {
                    result[k] = sortedFirst[firstIndex];
                    ++firstIndex;
                }
                else if (sortedFirst[firstIndex] > sortedSecond[secondIndex])
                {
                    result[k] = sortedSecond[secondIndex];
                    ++secondIndex;
                    _counter += (sortedFirst.Length - firstIndex);
                }
            }

            return result;
        }
    }
}