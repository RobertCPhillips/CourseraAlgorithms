using System;
using System.Linq;

namespace InversionCounter
{
    class Program
    {
        private static void Main()
        {
            Assignment();
        }

        static void Assignment()
        {
            var fileItems = System.IO.File.ReadAllLines("integerarray.txt");

            var inputArray = fileItems.Select(Int32.Parse).ToArray();

            var result = new IntInversionCounter().Count(inputArray);
            Console.WriteLine(result);

        }

        static void Simple()
        {
            var inputArray00 = new[] { 1, 3, 5, 2, 4, 6 };
            var inputArray01 = new[] { 2, 4, 6, 8, 9, 7, 5, 3, 1, 0, 11, 34, 21, 5555, 322 };
            var inputArray02 = new[] { 1, 2, 3, 4, 5, 6 };
            var inputArray03 = new[] { 6, 5, 4, 3, 2, 1 };

            var inputArray04 = new[]
                {
                    4, 80, 70, 23, 9, 60, 68, 27, 66, 78, 12, 40, 52, 53, 44, 8, 49, 28, 18, 46, 21, 39, 51, 7, 87, 99, 69,
                    62, 84, 6, 79, 67, 14, 98, 83, 0, 96, 5, 82, 10, 26, 48, 3, 2, 15, 92, 11, 55, 63, 97, 43, 45, 81,
                    42, 95, 20, 25, 74, 24, 72, 91, 35, 86, 19, 75, 58, 71, 47, 76, 59, 64, 93, 17, 50, 56, 94, 90, 89,
                    32, 37, 34, 65, 1, 73, 41, 36, 57, 77, 30, 22, 13, 29, 38, 16, 88, 61, 31, 85, 33, 54
                };

            var inputArray05 = new[]
                {
                    37, 7, 2, 14, 35, 47, 10, 24, 44, 17, 34, 11, 16, 48, 1, 39, 6, 33, 43, 26, 40, 4, 28, 5, 38, 41, 42,
                    12, 13, 21, 29, 18, 3, 19, 0, 32, 46, 27, 31, 25, 15, 36, 20, 8, 9, 49, 22, 23, 30, 45
                };

            var result = new IntInversionCounter().Count(inputArray01);
            Console.WriteLine(result);
            result = new IntInversionCounter().Count(inputArray00);
            Console.WriteLine(result);
            result = new IntInversionCounter().Count(inputArray02);
            Console.WriteLine(result);
            result = new IntInversionCounter().Count(inputArray03);
            Console.WriteLine(result);
            result = new IntInversionCounter().Count(inputArray04);
            Console.WriteLine(result);
            result = new IntInversionCounter().Count(inputArray05);
            Console.WriteLine(result);
        }
    }
}
