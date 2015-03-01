﻿//Problem 18.* Remove elements from array
//Write a program that reads an array of integers and removes from it a minimal number of elements 
//in such a way that the remaining array is sorted in increasing order.
//Print the remaining sorted array.

using System;
using System.Collections.Generic;
using System.Linq;

class RemoveElementsFromArray
{
    static void FindSubset(int[] arr, int[] prev, List<int> result, int index, int count)
    {
        int i = 0;
        if (count == 0)
        {
            return;
        }
        result.Add(arr[index]);
        FindSubset(arr, prev, result, prev[index], count - 1);
    }
    static void Main()
    {
        int n = 9;
        int[] arr = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        int[] length = new int[n + 1];
        int[] prev = new int[n + 1];
        List<int> result = new List<int>();
        length[0] = 1;
        prev[0] = -1;
        int maxIndex = 0;
        int maxLength = 1;
        for (int i = 1; i < n; i++)
        {
            length[i] = 1;
            prev[i] = -1;
            for (int j = i - 1; j >= 0; j--)
            {
                if ((arr[j] <= arr[i]) && (length[i] < length[j] + 1))
                {
                    length[i] = length[j] + 1;
                    prev[i] = j;
                }
            }
            if (length[i] > maxLength)
            {
                maxIndex = i;
                maxLength = length[i];
            }
        }
        FindSubset(arr, prev, result, maxIndex, maxLength);
        result.Reverse();
        foreach (int item in result)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}
