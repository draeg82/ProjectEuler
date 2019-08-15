using System;
using System.Diagnostics;

namespace Project_Euler
{
    class Problem_10
    {
        static void Main(string[] args)
        {
            // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
            // Find the sum of all the primes below two million.

            Stopwatch timeIt = Stopwatch.StartNew();

            int limit = 2000000;  // below this number
            long answer = 0;

            for (int i = 2; i < limit; i++)
            {
                if (PrimalityTest(i))
                {
                    answer += i;
                }
            }

            timeIt.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Answer is {0}", answer);
            Console.WriteLine("Time taken was {0} ms", timeIt.ElapsedMilliseconds);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static bool PrimalityTest(int number)
        {
            double counter = 2;
            while (counter <= Math.Sqrt(number))
            {
                if (number % counter == 0)
                {
                    return false;
                }

                else
                {
                    counter++;
                }
            }
            return true;
        }
    }
}
