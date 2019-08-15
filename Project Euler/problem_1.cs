using System;
using System.Diagnostics;

namespace Project_Euler
{
    static class Problem_1
    {
        static void Main(string[] args)
        {
            // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
            // Find the sum of all the multiples of 3 or 5 below 1000.

            var watch = Stopwatch.StartNew();

            int answer = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i% 5 == 0)
                {
                    answer += i;
                }
            }
            watch.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The solution is " + answer.ToString());
            Console.WriteLine("The solution was found in " + watch.ElapsedMilliseconds.ToString() + "ms");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}