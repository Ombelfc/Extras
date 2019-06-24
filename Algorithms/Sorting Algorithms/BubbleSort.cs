using Algorithms.Utilities;
using System;
using System.Linq;

namespace Algorithms.Sorting_Algorithms
{
    public class BubbleSort : IBasicSortingAlgorithm
    {
        public int[] SortIncreasing(int[] toSort)
        {
            bool hasSwappedElements = false;
            int min = toSort.Min();

            for (int i = 0; i < toSort.Length; i++)
            {
                if (i == toSort.Length - 1 && hasSwappedElements)
                {
                    i = 0;
                    hasSwappedElements = false;
                }
                else if (i == toSort.Length - 1 && !hasSwappedElements)
                    break;

                if (toSort[i] > toSort[i + 1])
                {
                    var temp = toSort[i];
                    toSort[i] = toSort[i + 1];
                    toSort[i + 1] = temp;

                    hasSwappedElements = true;
                }
            }

            return toSort;
        }

        public int[] SortDecreasing(int[] toSort)
        {
            bool hasSwappedElements = false;
            int min = toSort.Min();

            for (int i = toSort.Length - 1; i >=0 ; i--)
            {
                if (i == 0 && hasSwappedElements)
                {
                    i = toSort.Length - 1;
                    hasSwappedElements = false;
                }
                else if (i == 0 && !hasSwappedElements)
                    break;

                if (toSort[i] > toSort[i - 1])
                {
                    var temp = toSort[i];
                    toSort[i] = toSort[i - 1];
                    toSort[i - 1] = temp;

                    hasSwappedElements = true;
                }
            }

            return toSort;
        }
    }
}
