using System;
using System.Collections.Generic;

namespace Example.Iterative.Yield.Examples
{
    public static class Example1
    {
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public static void ShowNumbers()
        {
            var list = PowerNumbers();

            foreach (var number in list)
                Console.WriteLine($"Number: {number}");
        }

        private static IEnumerable<double> PowerNumbers()
        {
            foreach (var number in numbers)
                yield return Math.Pow(number, 2);
        }
    }
}
