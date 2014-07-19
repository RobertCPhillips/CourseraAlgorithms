using System;
using System.IO;
using System.Linq;

namespace DynamicAlgorithms
{
    public class KnapsackFileReader
    {
        private readonly string _file;
        private readonly char[] _seperator = { ' ', '\t' };

        public KnapsackFileReader(string file)
        {
            _file = file;
        }

        public KnapsackProblem Read()
        {
            var lines = File.ReadAllLines(_file).Skip(1).ToArray(); //skip comment line
            var countData = lines[0].Split(_seperator, StringSplitOptions.RemoveEmptyEntries);
            var size = Int32.Parse(countData[0]);
            var itemCount = Int32.Parse(countData[1]);

            var knapsackItems = new int[itemCount + 1][]; //plus 1 for 1-based indexing

            var ki = 1;
            foreach (var line in lines.Skip(1)) //skip size line
            {
                var data = line.Split(_seperator, StringSplitOptions.RemoveEmptyEntries);
                var kiValue = Int32.Parse(data[0]);
                var kiWeight = Int32.Parse(data[1]);

                knapsackItems[ki] = new[] { kiValue, kiWeight };

                ++ki;
            }

            return new KnapsackProblem(size, itemCount, knapsackItems);
        }
    }
}