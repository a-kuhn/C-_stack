using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty List of type object
            List<object> emptyList = new List<object>();
            Console.WriteLine($"emptyList = {string.Join(", ", emptyList)}");

            //Add the following values to the list: 7, 28, -1, true, "chair"
            emptyList.Add(7);
            emptyList.Add(28);
            emptyList.Add(-1);
            emptyList.Add(true);
            emptyList.Add("chair");
            Console.WriteLine($"emptyList = {string.Join(", ", emptyList)}");

            //Loop through the list and print all values (Hint: Type Inference might help here!)
            foreach (var item in emptyList)
            {
                Console.WriteLine(item);
            }
            //Add all values that are Int type together and output the sum
            int intSums = 0;
            foreach (var item in emptyList)
            {
                if (item is int)
                {
                    intSums = intSums + (int)item;
                }
            }
            Console.WriteLine($"sum of all ints: {intSums}");
        }
    }
}
