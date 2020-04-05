using System;

namespace Fundementals_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for looping to print all values 1-255");
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("for loop that prints all values from 1-100 that are divisible by 3 or 5, but not both");
            for (int j = 1; j <= 100; j++)
            {
                if (j % 3 != 0 ^ j % 5 != 0)
                {
                    Console.WriteLine(j);
                }
            }

            Console.WriteLine("for loop to print 'Fizz' for multiples of 3, 'Buzz' for multiples of 5, and 'FizzBuzz' for numbers that are multiples of both 3 and 5");
            for (int k = 1; k <= 100; k++)
            {
                if (k % 3 == 0 & k % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (k % 3 == 0 & k % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (k % 3 != 0 & k % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else { Console.WriteLine(k); }
            }
            Console.WriteLine("while looping to print all values 1-255");
            int l = 1;
            while (l <= 255)
            {
                Console.WriteLine(l);
                l = l + 1;
            }

            Console.WriteLine("while loop that prints all values from 1-100 that are divisible by 3 or 5, but not both");
            int m = 1;
            while (m <= 100)
            {
                if (m % 3 != 0 ^ m % 5 != 0)
                {
                    Console.WriteLine(m);
                }
                m = m + 1;
            }

            Console.WriteLine("while loop to print 'Fizz' for multiples of 3, 'Buzz' for multiples of 5, and 'FizzBuzz' for numbers that are multiples of both 3 and 5");
            int n = 1;
            while (n <= 100)
            {
                if (n % 3 == 0 & n % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (n % 3 == 0 & n % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (n % 3 != 0 & n % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else { Console.WriteLine(n); }
                n = n + 1;
            }
        }
    }
}
