//Problem 4. Hexadecimal to decimal
//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
class HexadecimalToDecimal
{
    static void Main()
    {
        string hexadec = "4D2";
        Console.WriteLine(ConveHexDec(hexadec));
    }

    static int ConveHexDec(string hexadec)
    {
        int numberDec = 0;

        int j = 0;
        int digit = 0;
        for (int i = hexadec.Length - 1; i >= 0; i--)
        {
            switch (hexadec[i])
            {
                case '0': digit = hexadec[i] - '0'; break;
                case '1': digit = hexadec[i] - '0'; break;
                case '2': digit = hexadec[i] - '0'; break;
                case '3': digit = hexadec[i] - '0'; break;
                case '4': digit = hexadec[i] - '0'; break;
                case '5': digit = hexadec[i] - '0'; break;
                case '6': digit = hexadec[i] - '0'; break;
                case '7': digit = hexadec[i] - '0'; break;
                case '8': digit = hexadec[i] - '0'; break;
                case '9': digit = hexadec[i] - '0'; break;
                case 'A': digit = 10; break;
                case 'B': digit = 11; break;
                case 'C': digit = 12; break;
                case 'D': digit = 13; break;
                case 'E': digit = 14; break;
                case 'F': digit = 15; break;
            }
            numberDec += digit * (int)Math.Pow(16, j);
            ++j;
        }
        return numberDec;
    }
}
