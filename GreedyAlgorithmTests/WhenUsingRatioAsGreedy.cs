using GreedyAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace GreedyAlgorithmTests
{
    public class WhenUsingRatioAsGreedy
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
                _jobCostComputer = new RatioJobCost(_jobs);
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
            public void Should_Compute_67311454237()
            {
                var result = _jobCostComputer.Compute();
                result.ShouldEqual(67311454237);
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
                _jobCostComputer = new RatioJobCost(_jobs);
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
            public void Should_Compute_10548()
            {
                var result = _jobCostComputer.Compute();
                result.ShouldEqual(10548);
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
                _jobCostComputer = new RatioJobCost(_jobs);
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
            public void Should_Compute_138232()
            {
                var result = _jobCostComputer.Compute();
                result.ShouldEqual(138232);
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
                _jobCostComputer = new RatioJobCost(_jobs);
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
            public void Should_Compute_22()
            {
                var result = _jobCostComputer.Compute();
                result.ShouldEqual(22);
            }
        }
    }
}