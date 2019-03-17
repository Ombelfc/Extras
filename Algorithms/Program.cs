using Algorithms.Sorting_Algorithms;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingAlgorithms algorithms = new SortingAlgorithms();

            var sortedArrInc = algorithms.InsertionSort.SortIncreasing(new int[] { 5, 2, 4, 6, 1, 3 });
            Console.WriteLine("[{0}]", String.Join(", ", sortedArrInc));

            var sortedArrDec = algorithms.InsertionSort.SortDecreasing(new int[] { 5, 2, 4, 6, 1, 3 });
            Console.WriteLine("[{0}]", String.Join(", ", sortedArrDec));

            Console.ReadKey();
        }
    }
}
