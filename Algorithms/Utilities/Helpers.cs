using System;
using System.Collections.Generic;

namespace Algorithms.Utilities
{
    public static class Helpers
    {
        public static void PrintArray(IEnumerable<int> array) => Console.WriteLine("[ {0} ]", string.Join(" | ", array));
    }
}
