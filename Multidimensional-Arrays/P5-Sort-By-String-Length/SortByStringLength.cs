//Problem 5. Sort by string length
//You are given an array of strings. Write a method that sorts the array by the length of its elements
//(the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;

class SortByStringLength
{
    static void Main()
    {
        Console.WriteLine("Enter strings sepparated by comma:");
        var words = new List<string>(Console.ReadLine().Split(',').ToArray());
        

        var result = words.OrderBy(w => w.Length).ToArray();
        foreach (var word in result)
        {
            Console.WriteLine(word);
        }
    }
}