using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static int[] RandomArray()
        // Create a function called RandomArray() that returns an integer array
        {
            // Place 10 random integer values between 5-25 into the array
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rand.Next(5, 26);
            }
            int max = array[0];
            int min = array[0];
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
                total += array[i];
            }
            Console.WriteLine($"array: {string.Join(", ", array)}");
            // Print the min and max values of the array
            Console.WriteLine($"max: {max} \nmin: {min}");
            // Print the sum of all the values
            Console.WriteLine($"sum of all values: {total}");
            return array;
        }

        public static string TossCoin()
        //Create a function called TossCoin() that returns a string
        {
            //Have the function print "Tossing a Coin!"
            Console.WriteLine("Tossing a Coin!");
            //Randomize a coin toss with a result signaling either side of the coin
            Random rand = new Random();
            int toss = rand.Next(0, 2);
            //Have the function print either "Heads" or "Tails"
            string flip;
            if (toss == 0)
            {
                flip = "Heads";
            }
            else
            {
                flip = "Tails";
            }
            Console.WriteLine(flip);
            //Finally, return the result
            return flip;
        }

        public static double TossMultipleCoins(int num)
        //Create another function called TossMultipleCoins(int num) that returns a Double
        {
            //Have the function call the tossCoin function multiple times based on num value
            double headsCount = 0;
            double tailsCount = 0;
            for (int i = 0; i < num; i++)
            {
                string flip = TossCoin();
                if (flip == "Tails")
                {
                    tailsCount++;
                }
                else
                {
                    headsCount++;
                }
                Console.WriteLine($"flip: {flip}\ntailsCount: {tailsCount}\nheadsCount: {headsCount}");
            }
            double flipRatio = (headsCount / tailsCount);
            Console.WriteLine($"flipRatio: {flipRatio}");
            //Have the function return a Double that reflects the ratio of head toss to total toss
            return flipRatio;
        }


        public static List<string> Names()
        //Build a function Names that returns a list of strings.  In this function:
        {
            // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            List<string> names = new List<string> { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
            // Shuffle the list and print the values in the new order
            Random rand = new Random();
            for (int i = 0; i < rand.Next(5, 30); i++)
            {
                int idx = rand.Next(0, 5);
                string name = names[idx];
                names.RemoveAt(idx);
                names.Add(name);
            }
            Console.WriteLine($"shuffled names: {string.Join(", ", names)}");
            // Return a list that only includes names longer than 5 characters
            List<string> filteredNames = new List<string>();
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Length > 5)
                {
                    filteredNames.Add(names[i]);
                }
            }
            return filteredNames;
        }

        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(5);
            Names();
        }
    }
}
