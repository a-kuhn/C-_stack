using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for loop including 5 (<=)");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("for loop excluding 5 (<)");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("for loops using variables");
            int start = 0;
            int end = 5;
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("while loops ");
            int j = 0;
            while (j < 6)
            {
                Console.WriteLine(j);
                j = j + 1;
            }
        }
    }
}
