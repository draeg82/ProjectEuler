using System;
using System.Diagnostics;


namespace Project_Euler
{
    class Problem_4
    {
        static void Main(string[] args)
        {
            // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2 - digit numbers is 9009 = 91 × 99.
            // Find the largest palindrome made from the product of two 3 - digit numbers.

            var timeIt = Stopwatch.StartNew();

            string answer = "0";
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    string product = (i * j).ToString();

                    if (Convert.ToInt32(product) > Convert.ToInt32(answer))
                    {
                        if (IsPallindrome(product))
                        {
                            answer = product;
                        }
                    }
                }
            }

            timeIt.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The answer is " + answer);
            Console.WriteLine("The time taken was " + timeIt.ElapsedMilliseconds.ToString() + "ms");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static bool IsPallindrome(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

