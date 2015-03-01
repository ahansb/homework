//Problem 4. Binary search
//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
    {
        static void Main()
        {
            Console.WriteLine("Enter array of integers sepparated by comma");
            string input = Console.ReadLine();
            Console.WriteLine("Enter K");
            int k = int.Parse(Console.ReadLine());
            int[] numbers = input.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            numbers.OrderBy(n => n);
            Console.WriteLine(numbers.Last(x => x <= k));

        }
    }