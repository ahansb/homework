//Problem 14. Integer calculations
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;
using System.Collections.Generic;
using System.Linq;
class IntegerCalculations
    {
        static void Main()
        {
            Console.WriteLine("input int numbers sepparated by space");
            int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            Console.WriteLine("The min is {0}",array.Min());  // method for minimum
            Console.WriteLine("The max is {0}", array.Max());      //method for maximum
            Console.WriteLine("The average is {0}", array.Average()); //method average
            Console.WriteLine("The sum is {0}", array.Sum()); // method sum
            Console.WriteLine("The product is {0}", ProductOfNumbers(array)); // method product

        }

        static int ProductOfNumbers(int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
    }