//Problem 24. Order words
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OrderWords
    {
        static void Main()
        {
            Console.WriteLine("input a list of words sepparated by space");
            string input = Console.ReadLine();
            //string input = @"I hate formating and extracting strings";
            string[] words = input.Split(new char[]{' ','.',','},StringSplitOptions.RemoveEmptyEntries);
            
            Array.Sort(words);
            string result = string.Join(" ", words);
            Console.WriteLine(result);
        }
    }