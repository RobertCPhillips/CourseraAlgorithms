using System.Linq;

namespace GreedyAlgorithms
{
    public class DifferenceJobCost : IComputeScheduledJobCost
    {
        private readonly int[][] _jobs;

        public DifferenceJobCost(int[][] jobs)
        {
            _jobs = jobs;
        }

        public long Compute()
        {
            var orderedJobs = _jobs.OrderByDescending(j => j[0] - j[1]).ThenByDescending(j => j[0]);

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