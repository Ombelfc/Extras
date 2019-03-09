using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting_Algorithms
{
    public class SortingAlgorithms
    {
        public InsertionSort InsertionSort { get; }

        public SortingAlgorithms()
        {
            InsertionSort = new InsertionSort();
        }
    }
}
