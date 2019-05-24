using Algorithms.Sorting_Algorithms;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingAlgorithms sortingAlgorithms = new SortingAlgorithms();

            var sortedArrInc = sortingAlgorithms.InsertionSort.SortIncreasing(new int[] { 5, 2, 4, 6, 1, 3 });
            Console.WriteLine("[{0}]", string.Join(", ", sortedArrInc));

            var sortedArrDec = sortingAlgorithms.InsertionSort.SortDecreasing(new int[] { 5, 2, 4, 6, 1, 3 });
            Console.WriteLine("[{0}]", string.Join(", ", sortedArrDec));

            Console.ReadKey();
        }
    }
}
