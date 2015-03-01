//Problem 3. Decimal to hexadecimal
//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
class DecimalToHexadecimal
    {
        static void Main()
        {
            int numberDec = 1234;

            Console.WriteLine(ConvertToHexadecimal(numberDec));

        }

        static string ConvertToHexadecimal(int numberDec)
        {
            List<char> toHex = new List<char>();
            while (numberDec > 0)
            {
                switch(numberDec % 16)
                {
                    case 0: toHex.Add('0'); break;
                    case 1: toHex.Add('1'); break;
                    case 2: toHex.Add('2'); break;
                    case 3: toHex.Add('3'); break;
                    case 4: toHex.Add('4'); break;
                    case 5: toHex.Add('5'); break;
                    case 6: toHex.Add('6'); break;
                    case 7: toHex.Add('7'); break;
                    case 8: toHex.Add('8'); break;
                    case 9: toHex.Add('9'); break;
                    case 10: toHex.Add('A'); break;
                    case 11: toHex.Add('B'); break;
                    case 12: toHex.Add('C'); break;
                    case 13: toHex.Add('D'); break;
                    case 14: toHex.Add('E'); break;
                    case 15: toHex.Add('F'); break;
                }
                numberDec /= 16;

            }
            toHex.Reverse();
            string binary = string.Join("", toHex).ToString();
            return binary;
        }
    }