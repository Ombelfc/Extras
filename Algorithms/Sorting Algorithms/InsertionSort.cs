using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting_Algorithms
{
    public class InsertionSort
    {
        public int[] Sort(int[] toSort)
        {
            for (int i = 1; i < toSort.Length; i++)
            {
                int key = toSort[i];

                int j = i - 1;
                while(j >= 0 && toSort[j] > key)
                {
                    toSort[j + 1] = toSort[j];
                    j--;
                }
                toSort[j + 1] = key;
            }

            return toSort;
        }
    }
}
