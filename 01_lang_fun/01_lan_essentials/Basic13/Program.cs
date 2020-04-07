using System;

namespace Basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
            //print all ints 1 to 255
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            //print all odd ints 1 to 255
            for (int i = 1; i < 256; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintSum()
        {
            //print all ints 1 to 255 && running total
            int total = 0;
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
                total += i;
                Console.WriteLine($"total: {total}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            //loop through array of ints and print each int
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public static int FindMax(int[] numbers)
        {
            //print and return max val in array of ints
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            //print average of array of ints
            int len = numbers.Length;
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            Console.WriteLine(total / len);
        }

        public static int[] OddArray()
        {
            //creates and returns array of odd ints 1 to 255
            int[] odds = { };
            return odds;
        }

        public static int GreaterThanY(int[] numbers, int Y)
        {
            //return the number of array vals > Y
            int count = 0;
            foreach (int num in numbers)
            {
                if (num > Y) { count++; }
            }
            return count;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            //square each value in array
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public static void EliminateNegatives(int[] numbers)
        {
            //replace any neg ints in array with 0
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        public static void MinMaxAverage(int[] numbers)
        {
            //print max, min, and avg of array
            int max = numbers[0];
            int min = numbers[0];
            int len = numbers.Length;
            int total = 0;
            int avg = 0;
            for (int i = 0; i < len; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                total += numbers[i];
            }
            avg = total / len;
            Console.WriteLine($"max: {max}\nmin: {min}\navg: {avg}");
        }

        public static void ShiftValues(int[] numbers)
        {
            //shift each num to the left 1 space. replace last num with 0
            Console.WriteLine($"input array: {string.Join(", ", numbers)}");
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = 0;
            Console.WriteLine($"output array: {string.Join(", ", numbers)}");
        }

        public static object[] NumToString(int[] numbers)
        {
            //return obj array replacing neg ints with 'Dojo'
            object[] replaceNegIntsWithString = new object[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    replaceNegIntsWithString[i] = "Dojo";
                }
                else
                {
                    replaceNegIntsWithString[i] = numbers[i];
                }
            }
            Console.WriteLine($"object array: {string.Join(", ", replaceNegIntsWithString)}");
            return replaceNegIntsWithString;
        }

        static void Main(string[] args)
        {
            PrintNumbers();
            PrintOdds();
            PrintSum();
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 0, 4, 6, -2, -8, 33 };
            int[] numbers3 = { -4, -66, -1, -9 };
            int[] numbers4 = { 0, 0, 0 };
            LoopArray(numbers);
            Console.WriteLine(FindMax(numbers));
            Console.WriteLine(FindMax(numbers2));
            Console.WriteLine(FindMax(numbers3));
            Console.WriteLine(FindMax(numbers4));
            GetAverage(numbers);
            GetAverage(numbers2);
            GetAverage(numbers3);
            GetAverage(numbers4);
            Console.WriteLine(OddArray());
            Console.WriteLine(GreaterThanY(numbers, 3));
            Console.WriteLine(GreaterThanY(numbers2, 8));
            Console.WriteLine(GreaterThanY(numbers3, -8));
            SquareArrayValues(numbers);
            SquareArrayValues(numbers2);
            SquareArrayValues(numbers3);
            SquareArrayValues(numbers4);
            EliminateNegatives(numbers);
            EliminateNegatives(numbers2);
            EliminateNegatives(numbers3);
            EliminateNegatives(numbers4);
            MinMaxAverage(numbers);
            MinMaxAverage(numbers2);
            MinMaxAverage(numbers3);
            MinMaxAverage(numbers4);
            ShiftValues(numbers);
            ShiftValues(numbers2);
            ShiftValues(numbers3);
            ShiftValues(numbers4);
            NumToString(numbers);
            NumToString(numbers2);
            NumToString(numbers3);
            NumToString(numbers4);
        }
    }
}
