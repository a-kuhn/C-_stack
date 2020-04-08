using System;
using System.Collections.Generic;

namespace HungryNinja
{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public bool IsFull
        {
            get { return calorieIntake > 1200; }
        }

        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public void Eat(Food item)
        {
            if (IsFull) { Console.WriteLine($"This ninja is too full!"); }
            else
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                if (item.IsSpicy && item.IsSweet)
                {
                    Console.WriteLine($"wow, that {item.Name} was good! Nice balance of spicy and sweet");
                }
                else if (item.IsSpicy)
                {
                    Console.WriteLine($"Hoooo doggy, that {item.Name} is spicy!!");
                }
                else if (item.IsSweet)
                {
                    Console.WriteLine($"aww yisss gimme that sweet, sweet {item.Name} :) ");
                }
                else
                {
                    Console.WriteLine($"That {item.Name} was good!");
                }
            }
        }
    }
}