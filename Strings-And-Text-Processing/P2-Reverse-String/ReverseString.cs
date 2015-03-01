//Problem 2. Reverse string
//Write a program that reads a string, reverses it and prints the result at the console.

using System;

using System.Linq;


class ReverseString
{
    static void Main()
    {
        Console.WriteLine("input string to reverse");
        // string input = "sample";
        string input = Console.ReadLine();
        string output = ReversedString(input);
        Console.WriteLine(output);
    }

    private static string ReversedString(string input)
    {
        string output = string.Join("", input.Reverse());
            
        return output;
    }
}