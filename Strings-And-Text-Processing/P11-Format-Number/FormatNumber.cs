﻿//Problem 11. Format number
//Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
//percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class FormatNumber
    {
        static void Main()
        {
            Console.WriteLine("input an integer to see its formatation");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15:D}",input);
            Console.WriteLine("{0,15:X}", input);
            Console.WriteLine("{0,15:P}", input);
            Console.WriteLine("{0,15:E}", input);
        }
    }