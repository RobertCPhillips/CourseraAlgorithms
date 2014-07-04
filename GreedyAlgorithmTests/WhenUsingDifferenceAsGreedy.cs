using GreedyAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace GreedyAlgorithmTests
{
    public class WhenUsingDifferenceAsGreedy
    {
        [TestClass]
        public class WhenUsingHwJobs
        {
            private ILoadScheduledJobsFile _fileLoader;
            private int[][] _jobs;
            private IComputeScheduledJobCost _jobCostComputer;

            [TestInitialize]
            public void Init()
            {
                _fileLoader = new LoadScheduledJobsHwFile("jobs_hw.txt");
                _jobs = _fileLoader.LoadJobs();
                _jobCostComputer = new DifferenceJobCost(_jobs);
            }

            [TestMethod]
            public void Should_get_10000_jobs()
            {
                _jobs.Length.ShouldEqual(10000);

                _jobs[0][0].ShouldEqual(8);
                _jobs[0][1].ShouldEqual(50);

                _jobs[9999][0].ShouldEqual(68);
                _jobs[9999][1].ShouldEqual(15);
            }

            [TestMethod]
            public void Should_Compute_399900916()
            {
                var result = _jobCostComputer.Compute();
                result.ShouldEqual(69119377652);
            }
        }

        [TestClass]
        public class WhenUsingDf01Jobs
        {
            private ILoadScheduledJobsFile _fileLoader;
            private int[][] _jobs;
            private IComputeScheduledJobCost _jobCostComputer;

            [TestInitialize]
            public void Init()
            {
                _fileLoader = new LoadScheduledJobsHwFile("jobs_df_01.txt");
                _jobs = _fileLoader.LoadJobs();
                _jobCostComputer = new DifferenceJobCost(_jobs);
            }

            [TestMethod]
            public void Should_get_5_jobs()
            {
                _jobs.Length.ShouldEqual(5);

                _jobs[0][0].ShouldEqual(48);
                _jobs[0][1].ShouldEqual(14);

                _jobs[4][0].ShouldEqual(46);
                _jobs[4][1].ShouldEqual(6);
            }

            [TestMethod]
            public void Should_Compute_11336()
            {
                var result = _jobCostComputer.Compute();
                result.ShouldEqual(11336);
            }
        }

        [TestClass]
        public class WhenUsingDf02Jobs
        {
            private ILoadScheduledJobsFile _fileLoader;
            private int[][] _jobs;
            private IComputeScheduledJobCost _jobCostComputer;

            [TestInitialize]
            public void Init()
            {
                _fileLoader = new LoadScheduledJobsHwFile("jobs_df_02.txt");
                _jobs = _fileLoader.LoadJobs();
                _jobCostComputer = new DifferenceJobCost(_jobs);
            }

            [TestMethod]
            public void Should_get_18_jobs()
            {
                _jobs.Length.ShouldEqual(18);

                _jobs[0][0].ShouldEqual(50);
                _jobs[0][1].ShouldEqual(18);

                _jobs[17][0].ShouldEqual(8);
                _jobs[17][1].ShouldEqual(88);
            }

            [TestMethod]
            public void Should_Compute_145924()
            {
                var result = _jobCostComputer.Compute();
                result.ShouldEqual(145924);
            }
        }
        [TestClass]
        public class WhenUsingDf03Jobs
        {
            private ILoadScheduledJobsFile _fileLoader;
            private int[][] _jobs;
            private IComputeScheduledJobCost _jobCostComputer;

            [TestInitialize]
            public void Init()
            {
                _fileLoader = new LoadScheduledJobsHwFile("jobs_df_03.txt");
                _jobs = _fileLoader.LoadJobs();
                _jobCostComputer = new DifferenceJobCost(_jobs);
            }

            [TestMethod]
            public void Should_get_2_jobs()
            {
                _jobs.Length.ShouldEqual(2);

                _jobs[0][0].ShouldEqual(3);
                _jobs[0][1].ShouldEqual(5);

                _jobs[1][0].ShouldEqual(1);
                _jobs[1][1].ShouldEqual(2);
            }

            [TestMethod]
            public void Should_Compute_23()
            {
                var result = _jobCostComputer.Compute();
                result.ShouldEqual(23);
            }
        }
    }
}
