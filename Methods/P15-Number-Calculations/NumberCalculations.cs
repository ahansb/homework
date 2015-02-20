//Problem 15.* Number calculations
//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;
using System.Linq;
class NumberCalculations
{
static void Main()
        {
           
            //int[] array = { 1, 2, 3, 4 };
            double[] array = { 1.23456789, 2.3456789, 3.456789, 4.56789 };
            //long[] array = { 872323726, 93345365352, 52545434352 };


            Console.WriteLine("The min is {0}",array.Min());  // method for minimum
            Console.WriteLine("The max is {0}", array.Max());      //method for maximum
            Console.WriteLine("The average is {0}", array.Average()); //method average
            Console.WriteLine("The sum is {0}", array.Sum()); // method sum
            Console.WriteLine("The product is {0}", ProductOfNumbers(array)); // method product

        }

        static dynamic ProductOfNumbers<T>(params T[] array)
        {
            dynamic product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
    }