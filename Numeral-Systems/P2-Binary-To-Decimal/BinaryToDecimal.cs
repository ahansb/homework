//Problem 2. Binary to decimal
//Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;

class BinaryToDecimal
    {
        static void Main()
        {
            long binary = 10011010010;
            Console.WriteLine(ConveBinDec(binary));
        }

        static int ConveBinDec(long binary)
        {
            int numberDec = 0;
            string binStr = binary.ToString();
            int j = 0;
            int digit;
            for (int i = binStr.Length-1; i >= 0; i--)
            {
                digit = binStr[i]-'0';
                numberDec += digit * (int)Math.Pow(2, j);
                ++j;
            }
            return numberDec;
        }
    }
