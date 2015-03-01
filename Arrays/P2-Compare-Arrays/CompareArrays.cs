//Problem 2. Compare arrays
//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter the number of array elements you want to compare:");
        int lenght = int.Parse(Console.ReadLine());
        int[] firstArr = new int[lenght];
        int[] secArr = new int[lenght];


        for (int i = 0; i < lenght; i++)
        {
            Console.WriteLine("Enter element {0} of first array:", i + 1);
            firstArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < lenght; i++)
        {
            Console.WriteLine("Enter element {0} of second array:", i + 1);
            secArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < lenght; i++)
        {
            if (firstArr[i] < secArr[i])
            {
                Console.WriteLine("The {0} of the first array = {1} is smaller than the {0} element of second array = {2}", i + 1, firstArr[i], secArr[i]);
            }
            if (firstArr[i] > secArr[i])
            {
                Console.WriteLine("The {0} of the first array = {1} is bigger than the {0} element of second array = {2}", i + 1, firstArr[i], secArr[i]);
            }
            if (firstArr[i] == secArr[i])
            {
                Console.WriteLine("The {0} of the first array = {1} is equal to the {0} element of second array = {2}", i + 1, firstArr[i], secArr[i]);
            }
        }
    }
}