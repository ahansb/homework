//Problem 13. Reverse sentence
//Write a program that reverses the words in given sentence.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseSentence
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi!";
        Console.WriteLine("Input sentence to reverse");
        //string input = Console.ReadLine();
        


        //Delphi not and PHP, not C++ not is C#!
        //split words
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        //count words before ,
        int idxCom = input.IndexOf(',');
        string[] arrCom = input.Substring(0, idxCom).Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int wordComma = arrCom.Length;
        string[] arrAfter = input.Substring(idxCom + 1, input.Length - (idxCom + 1)).Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new StringBuilder();
        int j = arrAfter.Length - 1;
        for (int i = 0; i < arrAfter.Length; i++)
        {
            if (i == wordComma)
            {
                result.Append(',');
                result.Append(" ");
            }
            else if (i == wordComma - 1)
            {
                result.Append(arrAfter[j]);
            }
            else
            {
                result.Append(arrAfter[j]);
                result.Append(" ");
            }

            j--;
        }
        for (int i = arrCom.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                result.Append(arrCom[i]);
            }
            else
            {
                result.Append(arrCom[i]);

                result.Append(" ");
            }

        }
        result.Append(input[input.Length - 1]);
        Console.WriteLine(result.ToString());
    }
}