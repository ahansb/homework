//Problem 7. Reverse number
//Write a method that reverses the digits of given decimal number.

using System;
using System.Collections.Generic;
using System.Linq;
class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("input decimal number");
        string number = Console.ReadLine(); ;

        Console.WriteLine(ReverseString(number));
        
    }
    static char[] ReverseString(string number)
    {
        var reverse = number.Reverse().ToArray();
        return reverse;
    }
}