using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public static int DivisibleSumPairs(int n, int k, int[] ar)
        {
            int result = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int sum = ar[i] + ar[j];
                    if (sum % k == 0)
                        result++;
                }
            }

            return result;
        }

        public static int MigratoryBirds(List<int> arr)
        {
            return arr.GroupBy(x => x).OrderByDescending(grp => grp.Count())
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

        public static int SockMerchant(int n, int[] ar)
        {
            int count = 0;
            HashSet<int> colors = new HashSet<int>();

            for(int i = 0; i < n; i++)
            {
                if (!colors.Contains(ar[i]))
                    colors.Add(ar[i]);
                else
                {
                    count++;
                    colors.Remove(ar[i]);
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

            if (keyBoards[0] + dvs[0] > budget)
                return -1;

            int sum = 0;



            return sum;

            /*Array.Sort<int>(keyboards, (a, b) => b.CompareTo(a));
            Array.Sort<int>(drives, (a, b) => b.CompareTo(a));

            if (keyboards[keyboards.Length - 1] + drives[drives.Length - 1] > budget)
                return -1;

            for(int i = 0, j = 0; i < keyboards.Length - 1 && j < drives.Length - 1; )
            {
                var sum = keyboards[i] + drives[j];
                if (sum > budget)
                {
                    var first = keyboards[i + 1] + drives[j];
                    var second = keyboards[i] + drives[j + 1];
                    
                    if (first > budget && second > budget)
                    {
                        i++;
                        j++;
                    }
                    else
                    {
                        if (first > second && first > budget)
                            return second;
                        else if (first > second && first < budget)
                            return first;
                        else if (first < second && second > budget)
                            return first;
                        else if (first < second && second < budget)
                            return second;
                    }
                }
                else
                    return sum;
            }

            return -1;*/
        }

        #region Helpers

        private static int FindNextMultiple(int grade)
        {
            if ((grade) % 5 == 0) return grade;
            else if ((grade + 1) % 5 == 0) return grade + 1;
            else if ((grade + 2) % 5 == 0) return grade + 2;
            else return grade;
        }

        #endregion
    }
}
