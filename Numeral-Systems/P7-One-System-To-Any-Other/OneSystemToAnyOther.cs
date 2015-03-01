//Problem 7. One system to any other
//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class OneSystemToAnyOther
    {
        static void Main()
        {
            Console.WriteLine("Enter the num sys you want to write [1-16]:");
            int sBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number");
            string number = Console.ReadLine();
            Console.WriteLine("Enter the num sys you want to convert into [1-16]:");
            int dBase = int.Parse(Console.ReadLine());
            Console.WriteLine("The number is: {0}",ConvertDecToAny(ConvertAnyToDec(number, sBase), dBase));
        }
        static string ConvertDecToAny(int numberDec, int dBase)
        {
            List<char> toAny = new List<char>();
            while (numberDec > 0)
            {
                switch (numberDec % dBase)
                {
                    case 0: toAny.Add('0'); break;
                    case 1: toAny.Add('1'); break;
                    case 2: toAny.Add('2'); break;
                    case 3: toAny.Add('3'); break;
                    case 4: toAny.Add('4'); break;
                    case 5: toAny.Add('5'); break;
                    case 6: toAny.Add('6'); break;
                    case 7: toAny.Add('7'); break;
                    case 8: toAny.Add('8'); break;
                    case 9: toAny.Add('9'); break;
                    case 10: toAny.Add('A'); break;
                    case 11: toAny.Add('B'); break;
                    case 12: toAny.Add('C'); break;
                    case 13: toAny.Add('D'); break;
                    case 14: toAny.Add('E'); break;
                    case 15: toAny.Add('F'); break;
                }
                numberDec /= dBase;

            }
            toAny.Reverse();
            string any = string.Join("", toAny).ToString();
            return any;
        }
        static int ConvertAnyToDec(string hexadec, int sBase)
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
                numberDec += digit * (int)Math.Pow(sBase, j);
                ++j;
            }
            return numberDec;
        }
    }