//Problem 5. Larger than neighbours
//Write a method that checks if the element at given position in given array of integers
//is larger than its two neighbours (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("input int array sepparated by comma");
        int[] array = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("input the position of number you want to check");
        int posit = int.Parse(Console.ReadLine());
        Console.WriteLine("is bigger than neighbours - {0}",IsLargerThanNeighbours(array,posit));
    }
    static bool IsLargerThanNeighbours(int[] array, int position)
    {
        bool isLarge = false;
        if (position - 1 < 0)
        {
            if (array[position] > array[position + 1])
            {
                isLarge = true;
            }
        }
        else if (position + 1 >= array.Length)
        {
            if (array[position] > array[position - 1])
            {
                isLarge = true;
            }
        }
        else
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                isLarge = true;
            }
        }
        return isLarge;

    }
}