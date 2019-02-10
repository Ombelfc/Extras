using System;
using System.Collections.Generic;
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
