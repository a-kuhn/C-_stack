using System;
using System.Collections.Generic;

namespace HungryNinja
{
    public class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("cheesecake", 1000, false, true),
                new Food("hot and sour soup", 250, true, false),
                new Food("chili mango", 150, true, true),
                new Food("saag paneer", 400, false, false),
                new Food("coconut shrimp", 550, false, true)
            };
        }

        public Food Serve()
        //randomly return a food from the menu
        {
            Random rand = new Random();
            Food serving = Menu[rand.Next(0, Menu.Count)];
            Console.WriteLine($"serving up some {serving.Name}...");
            return serving;
        }
    }
}