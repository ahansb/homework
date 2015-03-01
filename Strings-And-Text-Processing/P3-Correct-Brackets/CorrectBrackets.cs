//Problem 3. Correct brackets
//Write a program to check if in a given expression the brackets are put correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CorrectBrackets
{
    static void Main()
    {
        //string input = "((a+b)/5-d)";
        //string input = ")(a+b))";
        //string input = "((a*22)+b)/(1-c)*d)";
        Console.WriteLine("input expression to check brackets");
        string input = Console.ReadLine();
        
        Console.WriteLine(AreBracketsCorrect(input)); 
    }

    static bool AreBracketsCorrect(string input)
    {
        int countRBracket = 0;
        int countLBracket = 0;
        int idxRB = 0;
        int idxLb = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                ++countRBracket;
            }
            else if (input[i] == ')')
            {
                ++countLBracket;
            }
        }
        bool isCorrect = true;
        if (countLBracket != countRBracket || input.IndexOf('(') > input.IndexOf(')'))
        {
            isCorrect = false;
        }
        return isCorrect;
    }
}