using System;
using DynamicAlgorithms;

namespace TspHw
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new TspFileReader(@"tsp_hw.txt").Read();
            var solver = new TspSolver(data);
            var result = solver.Execute();

            Console.WriteLine(result);
        }
    }
}
