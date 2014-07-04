using System.Linq;

namespace GreedyAlgorithms
{
    public class RatioJobCost : IComputeScheduledJobCost
    {
        private readonly int[][] _jobs;

        public RatioJobCost(int[][] jobs)
        {
            _jobs = jobs;
        }

        public long Compute()
        {
            var orderedJobs = _jobs.OrderByDescending(j => (float) j[0] / (float) j[1]);

            var result = 0L;
            var length = 0L;

            foreach (var job in orderedJobs)
            {
                length += job[1];
                result += length * job[0];
            }

            return result;
        }
    }
}