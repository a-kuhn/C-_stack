using System;

namespace HumanOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Buttercup");
            Human h2 = new Human("Mia");
            Console.WriteLine(h1.Name);
            Console.WriteLine(h2.Name);
            h1.Attack(h2);
            Console.WriteLine($"Mia's health after attack: {h2.Health}");
        }
    }
}
