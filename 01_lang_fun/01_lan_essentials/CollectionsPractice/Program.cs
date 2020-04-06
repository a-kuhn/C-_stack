using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to hold integer values 0 through 9
            int[] arrayOfInts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] arrayOfStrings = { "Tim", "Martin", "Nikki", "Sara" };
            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] arrayOfBool = { true, false, true, false, true, false, true, false, true, false };

            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string> { "vanilla", "chocolate chip", "black raspberry", "cookies and cream", "butter pecan" };
            // Output the length of this list after building it
            Console.WriteLine(flavors.Count);
            // Output the third flavor in the list, then remove this value
            Console.WriteLine(flavors[2]);
            flavors.Remove("black raspberry");
            // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine(flavors.Count);

            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> newDict = new Dictionary<string, string>();
            // Add key/value pairs to this dictionary where: (1) each key is a name from your names array (2) each value is a randomly select a flavor from your flavors list.
            Random rand = new Random();
            foreach (string name in arrayOfStrings)
            {
                newDict.Add(name, flavors[rand.Next(0, 4)]);
            }
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (KeyValuePair<string, string> entry in newDict)
            {
                Console.WriteLine($"{entry.Key} loves {entry.Value} ice cream.");
            }
        }
    }
}
