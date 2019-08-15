using System;
using System.Diagnostics;

namespace Project_Euler
{
    class Problem_5
    {
        static void Main(string[] args)
        {
            // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ?

            var timeIt = Stopwatch.StartNew();
            bool answerFound = false;
            int i = 1;
            while (!answerFound)
            {
                answerFound = answer(i);
                i += 1;
            }
            i -= 1;

            timeIt.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Answer is " + i.ToString());
            Console.WriteLine("Time taken was " + timeIt.ElapsedMilliseconds.ToString() + "ms");
            Console.ForegroundColor = ConsoleColor.White;


        }

        static bool answer(int number)
        {
            for (int i = 1; i < 21; i++)
            {
                if (number % i != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
