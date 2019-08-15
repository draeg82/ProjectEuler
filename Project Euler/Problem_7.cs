using System;
using System.Diagnostics;
using System.Numerics;

namespace Project_Euler
{
    class Problem_7
    {
        static void Main(string[] args)
        {
            // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
            // What is the 10 001st prime number ?

            Stopwatch timeIt = Stopwatch.StartNew();

            int primesFound = 0;
            int number = 2;

            while (primesFound < 10001)
            {
                if (PrimalityTest(number))
                {
                    primesFound += 1;

                }
                number += 1;
            }
            number -= 1;

            timeIt.Stop();
            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Prime number " + primesFound.ToString() + " is " + number.ToString());
            Console.WriteLine("Time taken was " + timeIt.ElapsedMilliseconds.ToString() + "ms");
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
