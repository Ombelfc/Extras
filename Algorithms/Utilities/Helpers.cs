using System;
using System.Collections.Generic;

namespace Algorithms.Utilities
{
    internal static class Helpers
    {
        public static void PrintArray(IEnumerable<int> array) => Console.WriteLine("[ {0} ]", string.Join(" | ", array));
    }
}
