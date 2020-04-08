using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buff1 = new Buffet();
            Ninja ninja1 = new Ninja();
            while (!ninja1.IsFull)
            {
                ninja1.Eat(buff1.Serve());
            }
        }
    }
}
