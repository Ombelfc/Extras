using Algorithms.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Problem_Solving.Implementation
{
    public static class Solutions
    {
        public static int[] GradingStudents(int[] grades)
        {
            List<int> scores = new List<int>(grades.Length);

            foreach (var grade in grades)
            {
                if (grade >= 38)
                {
                    scores.Add(FindNextMultiple(grade));
                }
                else
                {
                    scores.Add(grade);
                }
            }

            return scores.ToArray();
        }

        public static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int app = 0;
            int orr = 0;

            foreach (var ap in apples)
            {
                if ((a + ap) >= s && (a + ap) <= t) app++;
            }

            foreach (var or in oranges)
            {
                if ((b + or) <= t && (b + or) >= s) orr++;
            }

            Console.WriteLine(app);
            Console.WriteLine(orr);
        }

        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            string no = "NO";
            string yes = "YES";

            if ((x1 < x2) && (v1 < v2 || v1 == v2)) return no;
            else if (((x1 - x2) % (v2 - v1)) != 0) return no;

            return yes;
        }

        public static int[] BreakingRecords(int[] scores)
        {
            int maxRecord = 0;
            int minRecord = 0;
            int highestScore = scores[0];
            int lowestScore = scores[0];

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < lowestScore)
                {
                    lowestScore = scores[i];
                    minRecord++;
                }

                if (scores[i] > highestScore)
                {
                    highestScore = scores[i];
                    maxRecord++;
                }
            }

            return new int[] { maxRecord, minRecord };
        }

        public static int Birthday(List<int> s, int d, int m)
        {
            int result = 0;

            for (int i = 0; i < s.Count - m + 1; i++)
            {
                int sum = 0;
                for (int j = i; j < i + m; j++)
                {
                    sum += s[j];
                }

                if (sum == d)
                    result++;
            }

            return result;
        }

        public static int DivisibleSumPairs(int n, int k, int[] arr)
        {
            int result = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int sum = arr[i] + arr[j];
                    if (sum % k == 0)
                        result++;
                }
            }

            return result;
        }

        public static int MigratoryBirds(List<int> sequence)
        {
            return sequence.GroupBy(x => x).OrderByDescending(grp => grp.Count())
                .ThenBy(grp => grp.Key).First().Key;
        }

        public static string DayOfProgrammer(int year)
        {
            var result = String.Empty;

            // Julian calendar
            if (year < 1918)
            {
                // Leap year
                if (year % 4 == 0)
                    result = $"12.09.{year}";
                else
                    result = $"13.09.{year}";
            }
            // Gregorian calendar
            else if (year > 1918)
            {
                // Leap year
                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                    result = $"12.09.{year}";
                else
                    result = $"13.09.{year}";
            }
            else if (year == 1918)
            {
                result = $"26.09.{year}";
            }

            return result;
        }

        public static void BonAppetit(List<int> bill, int k, int b)
        {
            var removed = bill.Remove(bill[k]);
            if(removed)
            {
                var sum = bill.Sum();

                if ((sum / 2) == b)
                    Console.WriteLine("Bon Appetit");
                else
                    Console.WriteLine($"{b - (sum / 2)}");
            }
        }

        public static int SockMerchant(int n, int[] arr)
        {
            int count = 0;
            HashSet<int> colors = new HashSet<int>();

            for(int i = 0; i < n; i++)
            {
                if (!colors.Contains(arr[i]))
                    colors.Add(arr[i]);
                else
                {
                    count++;
                    colors.Remove(arr[i]);
                }
            }

            return count;

            /*int count = 0;
            List<int> indexes = new List<int>();

            for(int i = 0; i < ar.Length - 1; i++)
            {
                if (indexes.Contains(i))
                    continue;

                int key = ar[i];

                for(int j = i + 1; j < ar.Length; j++)
                {
                    if (!indexes.Contains(j) && ar[j] == key)
                    {
                        count++;
                        indexes.Add(i);
                        indexes.Add(j);
                        break;
                    }
                }
            }

            return count;*/
        }

        public static int PageCount(int n, int p)
        {
            var firstPage = Math.Abs(p / 2);
            if ((n % 2) == 0)
                n++;

            int secondPage = Math.Abs((p - n) / 2);
            return firstPage < secondPage ? firstPage : secondPage;
        }

        public static int CountingValleys(int n, string s)
        {
            int vallies = 0;
            int altitude = 0;
            bool inVally = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'U')
                    altitude++;
                else if (s[i] == 'D')
                    altitude--;

                if (altitude == 0 && inVally)
                    inVally = false;

                if (altitude == -1 && !inVally)
                {
                    inVally = true;
                    vallies++;
                }   
            }

            return vallies;
        }

        public static int GetMoneySpent(int[] keyboards, int[] drives, int budget)
        {
            var keyBoards = keyboards.Where(k => k < budget).ToList();
            var dvs = drives.Where(d => d < budget).ToList();

            keyBoards.Sort();
            dvs.Sort();

            int sum = 0;
            List<int> Sums = new List<int>();

            for (int i = 0; i < keyBoards.Count(); i++)
                for (int j = 0; j < dvs.Count(); j++)
                {
                    if (keyBoards[i] + dvs[j] <= budget)
                        Sums.Add(keyBoards[i] + dvs[j]);
                    else
                        break;
                }

            sum = Sums.Count() > 0 ?  Sums.Max() : -1;

            return sum;
        }

        public static string CatAndMouse(int x, int y, int z)
        {
            var a = Math.Abs(x - z);
            var b = Math.Abs(y - z);

            if (a == b)
                return "Mouse C";
            else if (a < b)
                return "Cat A";
            else
                return "Cat B";
        }

        public static int FormingMagicSquare(int[][] s)
        {
            int[][][] possiblePermutations = new int[][][] 
            {
                new int[][] { new int[] { 8, 1, 6 }, new int[] { 3, 5, 7 }, new int[] { 4, 9, 2 } }, // 1
                new int[][] { new int[] { 6, 1, 8 }, new int[] { 7, 5, 3 }, new int[] { 2, 9, 4 } }, // 2
                new int[][] { new int[] { 4, 9, 2 }, new int[] { 3, 5, 7 }, new int[] { 8, 1, 6 } }, // 3
                new int[][] { new int[] { 2, 9, 4 }, new int[] { 7, 5, 3 }, new int[] { 6, 1, 8 } }, // 4
                new int[][] { new int[] { 8, 3, 4 }, new int[] { 1, 5, 9 }, new int[] { 6, 7, 2 } }, // 5
                new int[][] { new int[] { 4, 3, 8 }, new int[] { 9, 5, 1 }, new int[] { 2, 7, 6 } }, // 6
                new int[][] { new int[] { 6, 7, 2 }, new int[] { 1, 5, 9 }, new int[] { 8, 3, 4 } }, // 7
                new int[][] { new int[] { 2, 7, 6 }, new int[] { 9, 5, 1 }, new int[] { 4, 3, 8 } }, // 8
            };

            int minCost = int.MaxValue;
            for (int permutation = 0; permutation < 8; permutation++)
            {
                int permutationCost = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                        permutationCost += Math.Abs(s[i][j] - possiblePermutations[permutation] [i] [j]);
                }
                minCost = Math.Min(minCost, permutationCost);
            }

            return minCost;
        }

        public static int PickingNumbers(List<int> sequence)
        {
            sequence.Sort();
            int max = 1;

            for (int i = 0; i < sequence.Count - 1; i++)
            {
                int currentMax = 1;

                for (int j = i + 1; j < sequence.Count; j++)
                {
                    if (Math.Abs(sequence[i] - sequence[j]) <= 1)
                        currentMax++;
                }

                if (currentMax > max)
                    max = currentMax;
            }

            return max;
        }

        public static int[] ClimbingLeaderboard(int[] scores, int[] alice)
        {
            return new int[0];
        }

        public static int HurdleRace(int k, int[] heights)
        {
            int doses = heights.Max() - k;

            return doses > 0 ? doses : 0;
        }

        public static int DesignerPdfViewer(int[] h, string word)
        {
            int maxHeight = word.Max(c => h[c - 97]);
            int wordLength = word.Length;

            return maxHeight * wordLength;
        }

        #region Helpers

        private static int FindNextMultiple(int grade)
        {
            if ((grade) % 5 == 0) return grade;
            else if ((grade + 1) % 5 == 0) return grade + 1;
            else if ((grade + 2) % 5 == 0) return grade + 2;
            else return grade;
        }

        private static void PrintMatrix(int[][] s)
        {
            for (int i = 0; i < s.GetLength(0); i++)
            {
                for (int j = 0; j < s.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", s[i][j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        #endregion
    }
}
