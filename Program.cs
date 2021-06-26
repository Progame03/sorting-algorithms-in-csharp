//sorting algorithms in C# made by DJ::Ötzi (2021)

using System;
using System.Linq;

namespace SortingAlgorithms
{
    class Program
    {
        static int Main(string[] args)
        {
            int i, j, helpVar, min, next;
            int[] originalValues = {5, 3, 15, 2, 8, 25, 0, 4, 1};

            int[] values = originalValues;
            int noOfValues = values.Length;

            Console.WriteLine("\tSORTING ALGORITHMS IN C#\n");
            //direct (simple) algorithms

            //from left to right (using BUBBLESORT)
            for (i = 1; i <= noOfValues - 1; i++)
                for (j = noOfValues - 1; j >= i; j--)
                    if (values[j - 1] > values[j])//compare
                    { //swap values
                        helpVar = values[j - 1];
                        values[j - 1] = values[j];
                        values[j] = helpVar;
                    }

            Console.WriteLine("\nBUBBLESORT:");
            values.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            values = originalValues;

            //(cocktail-)shakersort
            for (i = 0; i < noOfValues - 1; i++)
            {
                min = i;
                for (j = i + 1; j < noOfValues; j++)
                    if (values[min] > values[j]) min = j;
                if (min != i)    //swap
                {
                    helpVar = values[min];
                    values[min] = values[i];
                    values[i] = helpVar;
                }

            }

            Console.WriteLine("\nSHAKERSORT:");
            values.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            values = originalValues;

            //insertionsort
            for (i = 1; i < noOfValues; i++)
            {
                next = values[i];
                for (j = i - 1; j >= 0 && next < values[j]; j--)
                    values[j + 1] = values[j];
                values[j + 1] = next;
            }

            Console.WriteLine("\nINSERTIONSORT:");
            values.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            //todo: implement improved algorithms

            return 0;
        }
    }
}
