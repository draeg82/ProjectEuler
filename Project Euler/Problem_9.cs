using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Project_Euler
{
    class Problem_9
    {
        static void Main(string[] args)
        {
            //  A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

            // a2 + b2 = c2
            // For example, 32 + 42 = 9 + 16 = 25 = 52.

            // There exists exactly one Pythagorean triplet for which a +b + c = 1000.
            // Find the product abc.

            Stopwatch timeIt = Stopwatch.StartNew();
            List<int> answerList =  BruteForce();
            int answer = answerList[0] * answerList[1] * answerList[2];
            timeIt.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Answer is {0}", answer);
            Console.WriteLine("Time taken was {0} ms", timeIt.ElapsedMilliseconds);
            Console.ForegroundColor = ConsoleColor.White;



        }

        static List<int> BruteForce()
        {
            List<int> returnList = new List<int>();

            for (int a = 0; a < 500; a++)
            {
                for (int b = 0; b < 500; b++)
                {
                    for (int c = 0; c < 500; c++)
                    {
                        if (a * a + b * b == c * c && a + b + c == 1000)
                        {
                            returnList.Add(a);
                            returnList.Add(b);
                            returnList.Add(c);
                            return returnList;
                        }
                    }
                }
            }

            return returnList;
        }

    }
}
