//Problem 6.* Matrix class
//Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, 
//subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;
using System.Collections.Generic;
using System.Linq;
class Matrix
{

    static void Main()
    {
        int[,] matrixOne = {{1,2,3},
                            {4,5,6},
                            {7,8,9}};

        int[,] matrixTwo = {{9,8,7},
                            {6,5,4},
                            {3,2,1}};

        //AddMatrix(matrixOne, matrixTwo);
        //SubtractMatrix(matrixOne, matrixTwo);
        //MultiplyMatrix(matrixOne, matrixTwo);
        ToStringMatrix(MultiplyMatrix(matrixOne, matrixTwo));
        ToStringMatrix(AddMatrix(matrixOne, matrixTwo));
        ToStringMatrix(SubtractMatrix(matrixOne, matrixTwo));
    }

    static string ToStringMatrix(int[,] matrix)
    {
        string str = "  ";
        string toStrMatr = null;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                toStrMatr += matrix[row, col] + str;
            }
            toStrMatr += "\n";
        }
        Console.WriteLine(toStrMatr);

        return toStrMatr;
    }

    static int[,] MultiplyMatrix(int[,] matrixOne, int[,] matrixTwo)
    {
        int[,] multiplyMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
        for (int row = 0; row < matrixOne.GetLength(0); row++)
        {
            for (int col = 0; col < matrixOne.GetLength(1); col++)
            {
                multiplyMatrix[row, col] = matrixOne[row, col] * matrixTwo[col, row];
            }
        }
        return multiplyMatrix;
    }

    static int[,] SubtractMatrix(int[,] matrixOne, int[,] matrixTwo)
    {
        int[,] subtractMatrix = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];
        for (int row = 0; row < matrixOne.GetLength(0); row++)
        {
            for (int col = 0; col < matrixOne.GetLength(1); col++)
            {
                subtractMatrix[row, col] = matrixOne[row, col] - matrixTwo[row, col];
            }
        }
        return subtractMatrix;
    }

    static int[,] AddMatrix(int[,] matrixOne, int[,] matrixTwo)
    {
        int[,] sumMatrix = new int[matrixOne.GetLength(0),matrixOne.GetLength(1)];
        for (int row = 0; row < matrixOne.GetLength(0); row++)
        {
            for (int col = 0; col < matrixOne.GetLength(1); col++)
            {
                sumMatrix[row, col] = matrixOne[row, col] + matrixTwo[row, col];
            }
        }
        return sumMatrix;
    }


}