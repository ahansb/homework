//Problem 9. Sorting array
//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 14, 5, 6, 7, 8, 9 };
        int startIdx = 0;
        int lastIdx = array.Length;
        Console.WriteLine("MAX is : {0}", MaximalElementInPortion(array, startIdx, lastIdx));
        Console.WriteLine("SORTED is {0}",string.Join(", ",SortMaxElPortion(array))); 
    }

    static List<int> SortMaxElPortion(int[] array)
    {
       
        
        var listSortReverse = new List<int>();
        for (int i = 0; i < array.Length; i++)
        {
            listSortReverse.Add(MaximalElementInPortion(array, 0, array.Length));
            array[Array.IndexOf(array,(MaximalElementInPortion(array, 0, array.Length)))]= int.MinValue;
        }
        listSortReverse.Reverse();
        return listSortReverse;
    }

    static int MaximalElementInPortion(int[] array, int startIdx, int lastIdx)
    {
        int[] bestArray = new int[(lastIdx-startIdx)];
        int bestElement;
        for (int i = startIdx,j=0; i < lastIdx;j++, i++)
        {
            bestArray[j] = array[i];
        }
        bestElement = bestArray.Max();
        return bestElement;
    }
}