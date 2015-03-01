//Problem 1. Decimal to binary
//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;

class DecimalToBinary
    {
        static void Main()
        {
            int numberDec = 1234;

            Console.WriteLine(  ConvertToBinary(numberDec));

        }

        static string ConvertToBinary(int numberDec)
        {
            List<int> toBin = new List<int>();
            while(numberDec>0)
            {
                toBin.Add( numberDec % 2);
                numberDec /=2;

            }
            toBin.Reverse();
            string binary = string.Join("", toBin).ToString();
            return binary;
        }
    }