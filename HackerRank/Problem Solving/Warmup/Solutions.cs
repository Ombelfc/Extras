using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Problem_Solving.Warmup
{
    public static class Solutions
    {
        public static int SolveMeFirst(int a, int b)
        {
            return a + b;
        }

        public static int SimpleArraySum(int[] arr)
        {
            var sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static List<int> CompareTheTriplets(List<int> a, List<int> b)
        {
            int aS = 0, bS = 0;

            if (a[0] > b[0]) aS++;
            else if (a[0] < b[0]) bS++;

            if (a[1] > b[1]) aS++;
            else if (a[1] < b[1]) bS++;

            if (a[2] > b[2]) aS++;
            else if (a[2] < b[2]) bS++;

            return new List<int>() { aS, bS };
        }

        public static long AVeryBigSum(long[] arr)
        {
            long sum = 0;
            Array.ForEach(arr, delegate (long i) { sum += i; });
            return sum;
        }

        public static int DiagonalDifference(int[][] arr)
        {
            int diag1 = 0;
            int diag2 = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                diag1 += arr[i][i];
                diag2 += arr[i][(arr.Length - 1) - count];
                count++;
            }

            return Math.Abs(diag1 - diag2);
        }

        public static void PlusMinus(int[] arr)
        {
            int length = arr.Length;

            int pos = 0;
            int neg = 0;
            int zero = 0;

            Array.ForEach(arr, delegate (int i)
            {
                var res = (i == 0) ? zero++ : i > 0 ? pos++ : i < 0 ? neg++ : 0;
            });

            Console.WriteLine((float)pos / length);
            Console.WriteLine((float)neg / length);
            Console.WriteLine((float)zero / length);
        }

        public static void Staircase(int n)
        {
            int count = n - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= count) Console.Write("#");
                    else Console.Write(" ");
                }
                Console.WriteLine();
                count--;
            }
        }

        public static void MiniMaxSum(int[] arr)
        {
            Array.Sort(arr);

            long minSum = 0;
            long maxSum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minSum += arr[i];
                maxSum += arr[i + 1];
            }

            Console.Write($"{minSum} {maxSum}");
        }

        public static int BirthdayCakeCandles(int[] ar)
        {
            int max = ar.Max();
            return ar.Where(x => x == max).Count();
        }

        public static string TimeConversion(string inputDate)
        {
            DateTime dateTime = DateTime.ParseExact(inputDate, "hh:mm:sstt",
                                System.Globalization.CultureInfo.InvariantCulture);

            return dateTime.ToString("HH:mm:ss");
        }
    }
}
