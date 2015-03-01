//Problem 6. Sum integers
//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;
using System.Linq;
class SumIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter positive integers , separated by spaces");
            int sum = ReadArraySum();
            Console.WriteLine("The nums sum is {0}",sum);
        }

        static int ReadArraySum()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            return numbers.Sum();
        }
    }