//Problem 4. Appearance count
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
using System.Collections.Generic;
using System.Linq;
class AppearanceCount
{
    static void Main()
    {
        List<int> arrayList = new List<int>();
        Console.WriteLine("input numbers sepparated by space:");
        arrayList =Console.ReadLine()
        .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(item => int.Parse(item))
        .ToList();
        Console.WriteLine("input number looking for:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("the number looking for is met {0} times",NumberAppearance(arrayList,num));
    } 
    static int NumberAppearance(List<int> array, int number)
    {
       int numApp = array.Count(n => n == number);
       return numApp;
    }
}