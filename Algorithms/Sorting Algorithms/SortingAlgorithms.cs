using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting_Algorithms
{
    public class SortingAlgorithms
    {
        public InsertionSort InsertionSort { get; }
        public MergeSort MergeSort { get; }

        public SortingAlgorithms()
        {
            InsertionSort = new InsertionSort();
            MergeSort = new MergeSort();
        }
    }
}
