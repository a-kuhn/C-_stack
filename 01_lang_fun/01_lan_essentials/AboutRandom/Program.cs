using System;

namespace AboutRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            // namespace System has Random built in. to use, first need to create a random object
            Random rand = new Random();
            // then call .Next method on random object (rand)
            for (int val = 0; val < 10; val++)
            {
                //.Next takes two optional arguments lowest (inclusive) and highest (exclusive)
                Console.WriteLine("here's a random number between -2 and 18: " + rand.Next(-2, 18));
            }
        }
    }
}
