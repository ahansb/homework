//Problem 2. Get largest number
//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Input int one:");
        int one = int.Parse(Console.ReadLine());
        Console.WriteLine("Input int two:");
        int two = int.Parse(Console.ReadLine());
        Console.WriteLine("Input int three:");
        int three = int.Parse(Console.ReadLine());
        int max = GetMax(one, two);
        max = GetMax(max, three);
        Console.WriteLine("The max is {0}", max);
    }
    static int best = int.MinValue;
    static int GetMax(int a, int b)
    {
        if (a>=b)
        {
            best = a; 
        }
        else
        {
            best = b;
        }
        return best;
    }

}