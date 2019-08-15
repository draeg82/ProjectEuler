using System;
using System.Diagnostics;

namespace Project_Euler
{
    class Problem_6
    {
        static void Main(string[] args)
        {
            Stopwatch timeIt = Stopwatch.StartNew();
            double sumofsquares = SumOfSquares(100);
            double squareofsums = SquareOfSums(100);
            double answer = Math.Abs(sumofsquares - squareofsums);

            timeIt.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Answer is " + answer.ToString());
            Console.WriteLine("Time taken was " + timeIt.ElapsedMilliseconds.ToString() + "ms");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static double SumOfSquares(int number)
        {
            double returnValue = 0;
            for (int i = 1; i <= number; i++)
            {
                returnValue += Math.Pow(i, 2);
            }
            return returnValue;
        }

        static double SquareOfSums(int number)
        {
            double returnValue = 0;
            for (int i = 1; i <= number; i++)
            {
                returnValue += i;
            }
            returnValue = Math.Pow(returnValue, 2);
            return returnValue;
        }
    }
}
