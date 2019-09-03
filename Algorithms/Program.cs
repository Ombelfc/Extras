using Algorithms.Sorting_Algorithms;
using Algorithms.Utilities;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingAlgorithms sortingAlgorithms = new SortingAlgorithms();

            var testArray = new int[] { 5, 2, 4, 6, 1, 3 };

            //var sortedArrInc = sortingAlgorithms.BubbleSort.SortIncreasing((int[])testArray.Clone());
            //var sortedArrDec = sortingAlgorithms.BubbleSort.SortDecreasing((int[])testArray.Clone());
            var sortedFirstDesignArray = sortingAlgorithms.InsertionSort.FirstDesign((int[])testArray.Clone());

            //Helpers.PrintArray(sortedArrInc);
            //Helpers.PrintArray(sortedArrDec);
            Helpers.PrintArray(sortedFirstDesignArray);

            Console.ReadKey();
        }
    }
}
