using System;
using System.Diagnostics;


namespace Project_Euler
{
    class Problem_3
    {
        static void Main(string[] args)
        {

            // The prime factors of 13195 are 5, 7, 13 and 29.
            // What is the largest prime factor of the number 600851475143 ?

            var timeIt = Stopwatch.StartNew();
            long answer = LargestPrimeFactor(600851475143);
            timeIt.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Answer is " + answer.ToString());
            Console.WriteLine("Time taken was " + timeIt.ElapsedMilliseconds.ToString() + "ms");
            Console.ForegroundColor = ConsoleColor.White;

        }

        static long LargestPrimeFactor(long a)
        {
            long b = 2;
            while (a > b)
            {
                if (a % b == 0)
                {
                    a = a / b;
                    b = 2;
                }
                else
                {
                    b += 1;
                }
            }
            return b;
        }
    }
}
