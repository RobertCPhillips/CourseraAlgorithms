using System;
using System.IO;
using System.Linq;

namespace DynamicAlgorithms
{
    public class TspFileReader
    {
        private readonly string _file;
        private readonly char[] _seperator = { ' ', '\t' };

        public TspFileReader(string file)
        {
            _file = file;
        }

        public double[][] Read()
        {
            var lines = File.ReadAllLines(_file).Skip(1).ToArray(); //skip comment line
            var countData = lines[0].Split(_seperator, StringSplitOptions.RemoveEmptyEntries);
            var size = Int32.Parse(countData[0]);

            var points = new double[size][];

            var i = 0;
            foreach (var line in lines.Skip(1)) //skip size line
            {
                var data = line.Split(_seperator, StringSplitOptions.RemoveEmptyEntries);
                var x = double.Parse(data[0]);
                var y = double.Parse(data[1]);

                points[i] = new[] { x, y };
                i++;
            }

            return points;
        }
    }
}
