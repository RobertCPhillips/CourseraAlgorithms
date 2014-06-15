using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hashing
{
    public class MedianMaint
    {
        private readonly string _file;

        public MedianMaint(string file)
        {
            _file = file;
        }

        public int Execute()
        {
            var fileItems = File.ReadAllLines(_file).Select(Int32.Parse).ToArray();
            var results = new List<int>();
            var manager = new SortedSet<int>();

            for (var i = 1; i <= fileItems.Length; i++)
            {
                var @value = fileItems[i-1];
                manager.Add(@value);

                if (i%2 == 0) results.Add(manager.ElementAt((i-1)/2));
                else results.Add(manager.ElementAt((i)/2));
            }

            return results.Sum() % 10000;
        }
    }
}