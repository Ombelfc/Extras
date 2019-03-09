using Algorithms.Sorting_Algorithms;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingAlgorithms sorts = new SortingAlgorithms();

            var sortedArray = sorts.InsertionSort.Sort(new int[] { 5, 2, 4, 6, 1, 3 });
            Console.WriteLine("[{0}]", String.Join(", ", sortedArray));

            Console.ReadKey();
        }
    }
}
