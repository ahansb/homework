//Problem 5. Hexadecimal to binary
//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 class HexadecimalToBinary
    {
        static void Main()
        {
            string hexadec = "4D2";
            Console.WriteLine(ConveHexBin(hexadec));
        }
        static string ConveHexBin(string hexadec)
        {
            StringBuilder binFromHex = new StringBuilder();
            for (int i = 0; i < hexadec.Length; i ++)
            {
                switch (hexadec[i])
                {
                    case 'A': binFromHex.Append("1010"); break;
                    case 'B': binFromHex.Append("1011"); break;
                    case 'C': binFromHex.Append("1100"); break;
                    case 'D': binFromHex.Append("1101"); break;
                    case 'E': binFromHex.Append("1110"); break;
                    case 'F': binFromHex.Append("1111"); break;
                    case '0': binFromHex.Append("0000"); break;
                    case '1': binFromHex.Append("0001"); break;
                    case '2': binFromHex.Append("0010"); break;
                    case '3': binFromHex.Append("0011"); break;
                    case '4': binFromHex.Append("0100"); break;
                    case '5': binFromHex.Append("0101"); break;
                    case '6': binFromHex.Append("0110"); break;
                    case '7': binFromHex.Append("0111"); break;
                    case '8': binFromHex.Append("1000"); break;
                    case '9': binFromHex.Append("1001"); break;
                }
            }
            int index = 0;
            while (binFromHex[index]=='0')
            {
                binFromHex.Remove(0, 1);

            }
            return binFromHex.ToString();
            
        }
    }