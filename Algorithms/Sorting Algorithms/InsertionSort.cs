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

        public int[] FirstDesign(int[] toSort)
        {
            for (int i = 0; i < toSort.Length - 1; i++)
            {
                int key = toSort[i + 1];

                if (toSort[i] > key)
                {
                    int j = i;
                    while (j >= 0 && toSort[j] > key)
                    {
                        int temp = toSort[j];
                        toSort[j] = key;
                        toSort[j + 1] = temp;
                        j--;
                    }
                }
            }

            return toSort;
        }
    }
}
