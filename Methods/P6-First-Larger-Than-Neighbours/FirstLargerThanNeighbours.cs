//Problem 6. First larger than neighbours
//Write a method that returns the index of the first element in array that is larger than its neighbours, 
//or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("input int array sepparated by space");
        int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        for (int pos = 0; pos < array.Length; pos++)
        {
            bool isLarge = IsLargerThanNeighbours(array, pos);
            if(isLarge)
            {
                Console.WriteLine("on position {0} the number is bigger than neighbours", pos);
                break;
            }
        }
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