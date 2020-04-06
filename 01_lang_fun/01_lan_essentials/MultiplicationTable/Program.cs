using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 2d array: 10 arrays of 10 0's
            int[,] multTable = new int[10, 10];
            // loop through arrays and set value of first element (column 1)
            for (int i = 0; i < 10; i++)
            {
                //loop through each array and build multiplication factors
                for (int j = 0; j < 10; j++)
                {
                    multTable[i, j] = (i + 1) * (j + 1);
                }
            }
            // write table to console in 10x10 grid
            for (int k = 0; k < 10; k++)
            {
                string printString = "[";
                for (int l = 0; l < 10; l++)
                {
                    printString += string.Format("{0}, \t", multTable[k, l]);
                }
                Console.WriteLine(printString + "]");
            }
        }
    }
}
