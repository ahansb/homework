//Problem 8. Number as array
//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.
using System;
using System.Collections.Generic;
using System.Linq;
class NumberAsArray
{
    static void Main()
    {
        Console.WriteLine("input number one");
        string number = Console.ReadLine(); ;
        long[] numOne = NumsArray(number);
        Console.WriteLine("input number two");
        string numberTwo = Console.ReadLine(); ;
        long[] numTwo = NumsArray(numberTwo);

    }
    static long[] NumsArray(string number)
    {
        var chars = number.ToArray();
        var arr = new long[chars.Length];
        for (int i = 0; i < chars.Length; i++)
        {
            arr[((chars.Length - 1) - i)] = Convert.ToInt64(chars[i]);
        }
        return arr;
    }
}