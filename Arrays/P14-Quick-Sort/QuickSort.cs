//Problem 14. Quick sort
//Write a program that sorts an array of integers using the Quick sort algorithm.

using System;
using System.Collections.Generic;
class QuickSort
{
    static int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
            {
                left++;
            }
            while (numbers[right] > pivot)
            {
                right--;
            }
            if (left < right)
            {
                int temp = numbers[right];

                numbers[right] = numbers[left];

                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static void QuickSortMethod(int[] arr, int left, int right)
    {

        if (left < right)
        {

            int pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                QuickSortMethod(arr, left, pivot - 1);
            }

            if (pivot + 1 < right)
            {
                QuickSortMethod(arr, pivot + 1, right);
            }
        }
    }
    static void Main()
    {
        //int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4,10 , 0 , 12, 11, 19,17,15,18,13,14,16 };
        Console.WriteLine("Enter numbers separated by comma:");
        string input = Console.ReadLine();
        string[] inputStr = input.Split(',');
        int[] numbers = new int[inputStr.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(inputStr[i]);
        }
        

        int len = numbers.Length;
        Console.WriteLine("QuickSort Method");
        QuickSortMethod(numbers, 0, len - 1);
        for (int i = 0; i < len; i++)
        {
            Console.Write("{0}, ",numbers[i]);
        }
        Console.WriteLine();

    }
}




