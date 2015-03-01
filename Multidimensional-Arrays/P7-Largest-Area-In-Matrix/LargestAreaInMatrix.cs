//Problem 7.* Largest area in matrix
//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

using System;
using System.Collections.Generic;
using System.Linq;
class LargestAreaInMatrix
{
    static int[,] matrix;
    static bool[,] visited;
    static int counter;
    static int bestCount;
    static int number;
    static int bestNum;
    static void Main()
    {
        matrix = new[,]{{1, 3, 2, 2, 2, 4},
                         {3, 3, 3, 2, 4, 4},
                         {4, 3, 1, 2, 3, 3},
                         {4, 3, 1, 3, 3, 1},
                         {4, 3, 3, 3, 1, 1}};
        //bool
        visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
        for (int row = 0; row < visited.GetLength(0); row++)
        {
            for (int col = 0; col < visited.GetLength(1); col++)
            {
                visited[row, col] = false;
            }
        }

        //Cheking matrix
        bestCount = 0;
        for (int row = 0; row < matrix.GetLongLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLongLength(1); col++)
            {
                number = matrix[row, col];
                counter = 0;
                DeptFirstSerch(row, col);
                if (counter > bestCount)
                {
                    bestCount = counter;
                    bestNum = number;
                }
            }
        }
        Console.WriteLine("Area {0} cells of num {1}",bestCount,bestNum);

    }
    static void DeptFirstSerch(int row, int col)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1) || visited[row, col] == true) return;

        if (matrix[row, col] == number)
        {
            ++counter;
            visited[row, col] = true;
            DeptFirstSerch(row - 1, col);
            DeptFirstSerch(row + 1, col);
            DeptFirstSerch(row, col - 1);
            DeptFirstSerch(row, col + 1);
        }

        

    }
}