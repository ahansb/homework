//Problem 6. String length
//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
    {
        static void Main()
        {
            Console.WriteLine("Write a string of maximum 20 characters:");
            string input = Console.ReadLine();
            
            if (input.Length<=20)
            {
                Console.WriteLine(input.PadRight(20,'*'));
            }
            else
            {
                Console.WriteLine("The string should NOT be more than 20 chars.");
            }
        }
    }