using System;
using System.IO;
using System.Linq;

namespace GreedyAlgorithms
{
    public interface ILoadScheduledJobsFile
    {
        int[][] LoadJobs();
    }

    public class LoadScheduledJobsHwFile : ILoadScheduledJobsFile
    {
        private readonly string _file;
        private readonly char[] _seperator = { ' ' };

        public LoadScheduledJobsHwFile(string file)
        {
            _file = file;
        }

        public int[][] LoadJobs()
        {
            var result = File.ReadAllLines(_file).Skip(1).Select(line =>
            {
                var data = line.Split(_seperator);
                var w = Int32.Parse(data[0]);
                var l = int.Parse(data[1]);
                return new[] {w, l};

            }).ToArray();

            return result;
        }
    }
}