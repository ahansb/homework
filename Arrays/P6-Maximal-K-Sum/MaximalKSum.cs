//Problem 6. Maximal K sum
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximalKSum
{
    static void Main()
    {
        Console.WriteLine("Enter N numbers array");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many K elements sum");
        int k = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int sum=0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter number:");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        for (int i = n - k; i < n; i++)
        {
             sum += numbers[i];
            
        }
        Console.WriteLine("The biggest sum of K elements is {0}",sum);

    }
}