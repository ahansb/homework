//Problem 12. Index of letters
//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Linq;
class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        Console.WriteLine("enter word with allcaps");
        string word = Console.ReadLine();
        int index = 0;
        Console.WriteLine("the letter indexes are: ");
        for (int i = 0; i < word.Length; i++)
        {
            index = word[i] - 'A';
            Console.Write("{0} ", index+1);
        }
        Console.WriteLine();
        
    }
}