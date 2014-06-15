using System;
using Hashing;

namespace TwoSumHw
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoSum = new TwoSum("algo1_programming_prob_2sum_sub.txt");
            var result = twoSum.Execute();

            Console.WriteLine(result);
        }
    }
}
