using Algorithms.Utilities;

namespace Algorithms.Sorting_Algorithms
{
    public class InsertionSort : IBasicSortingAlgorithm
    {
        public int[] SortIncreasing(int[] toSort)
        {
            for (int i = 1; i < toSort.Length; i++)
            {
                int key = toSort[i];

                int j = i - 1;
                while (j >= 0 && toSort[j] > key)
                {
                    toSort[j + 1] = toSort[j];
                    j--;
                }
                toSort[j + 1] = key;
            }

            return toSort;
        }

        public int[] SortDecreasing(int[] toSort)
        {
            for (int i = toSort.Length - 2; i >= 0; i--)
            {
                int key = toSort[i];

                int j = i + 1;
                while (j < toSort.Length && toSort[j] > key)
                {
                    toSort[j - 1] = toSort[j];
                    j++;
                }
                toSort[j - 1] = key;
            }

            return toSort;
        }
    }
}
