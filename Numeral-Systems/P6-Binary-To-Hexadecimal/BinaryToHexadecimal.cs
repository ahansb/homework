////Problem 6. Binary to hexadecimal
////Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class BinaryToHexadecimal
{
    static void Main()
    {

        string binary = "10011010010";
        Console.WriteLine(BinToHex(binary));

    }

    static string BinToHex(string binary)
    {
        string bin = string.Empty;

        if (binary.Length % 4 != 0)
        {

            bin = binary.PadLeft((4 - (binary.Length % 4) + binary.Length), '0');
        }
        StringBuilder hexFromBin = new StringBuilder();
        for (int i = 0; i < bin.Length; i = i + 4)
        {
            switch (bin.Substring(i, 4))
            {
                case "1010": hexFromBin.Append('A'); break;
                case "1011": hexFromBin.Append('B'); break;
                case "1100": hexFromBin.Append('C'); break;
                case "1101": hexFromBin.Append('D'); break;
                case "1110": hexFromBin.Append('E'); break;
                case "1111": hexFromBin.Append('F'); break;
                case "0000": hexFromBin.Append('0'); break;
                case "0001": hexFromBin.Append('1'); break;
                case "0010": hexFromBin.Append('2'); break;
                case "0011": hexFromBin.Append('3'); break;
                case "0100": hexFromBin.Append('4'); break;
                case "0101": hexFromBin.Append('5'); break;
                case "0110": hexFromBin.Append('6'); break;
                case "0111": hexFromBin.Append('7'); break;
                case "1000": hexFromBin.Append('8'); break;
                case "1001": hexFromBin.Append('9'); break;
            }
        }
        return hexFromBin.ToString();
    }
}


