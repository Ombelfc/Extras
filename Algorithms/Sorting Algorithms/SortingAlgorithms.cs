using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting_Algorithms
{
    public class SortingAlgorithms
    {
        public IBasicSortingAlgorithm BubbleSort { get; } = new BubbleSort();
        public IBasicSortingAlgorithm InsertionSort { get; } = new InsertionSort();
        public IBasicSortingAlgorithm SelectionSort { get; } = new SelectionSort();

        //public MergeSort MergeSort { get; } = new MergeSort();

        public SortingAlgorithms() { }
    }
}
