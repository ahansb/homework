//Problem 3. Sequence n matrix
//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several 
//neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

using System;
using System.Collections.Generic;
using System.Linq;
class SequenceNMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter matrix of nxm");
        Console.WriteLine("Enter n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter m");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.WriteLine("input matrix[{0},{1}]:", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
        for (int row = 0; row < n; row++)
        {
            Console.WriteLine();
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
        }
        int horizCounter = 1;
        int bestHorizCounter = 1;
        int horizRow=0;
        int horizCol=0;

        int diagCounter = 1;
        int bestDiagCounter = 1;
        int diagRow=0;
        int diagCol=0;

        int vertCounter = 1;
        int bestVertCounter = 1;
        int vertRow=0;
        int vertCol=0;

        int leftDiagCounter = 1;
        int bestLeftDiagCounter = 1;
        int leftDiagRow = 0;
        int leftDiagCol = 0;


        //string[,] matrix = { { "ha" , "fifi", "ho", "hi" }, 
        //                     { "fo" , "ha"  , "hi", "xx" }, 
        //                     { "xxx", "ho"  , "ha", "xx" } };
        {
            //for horizontal check
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        horizCounter++;

                    }
                    else
                    {
                        horizCounter = 1;
                    }
                    if (horizCounter > bestHorizCounter)
                    {
                        bestHorizCounter = horizCounter;
                        horizRow = row;
                        horizCol = col;
                    }
                }
            }
            //for vertical check

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        vertCounter++;

                    }
                    else
                    {
                        vertCounter = 1;
                    }
                    if (vertCounter > bestVertCounter)
                    {
                        bestVertCounter = vertCounter;
                        vertRow = row;
                        vertCol = col;
                    }
                }
            }
            //right diagonal check

            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
            {
                if (matrix[row, col] == matrix[row + 1, col+1])
                {
                    ++diagCounter;
                }
                else
                {
                    diagCounter = 1;
                }
                if (diagCounter > bestDiagCounter)
                {
                    bestDiagCounter = diagCounter;
                    diagCol = col;
                    diagRow = row;
                }
            }
            //left diagonal
            for (int row = 0, col = matrix.GetLength(1); row < matrix.GetLength(0) - 1 && col < -1; row++, col--)
            {

                if (matrix[row, col] == matrix[row + 1, col - 1])
                {
                    ++leftDiagCounter;

                }
                else
                {
                    leftDiagCounter = 1;
                }

                if (leftDiagCounter > bestLeftDiagCounter)
                {
                    bestLeftDiagCounter = leftDiagCounter;
                    leftDiagCol = col;
                    leftDiagRow = row;
                }


            }

            //Cheking best answer
            if (bestDiagCounter > bestHorizCounter && bestDiagCounter > bestVertCounter && bestDiagCounter > bestLeftDiagCounter)
            {
                Console.WriteLine();
                for (int i = 0; i < bestDiagCounter; i++)
                {
                    Console.Write("{0}, ",matrix[diagRow, diagCol]);
                }
                
            }
            if (bestHorizCounter > bestVertCounter && bestHorizCounter > bestDiagCounter && bestHorizCounter > bestLeftDiagCounter)
            {
                Console.WriteLine();
                for (int i = 0; i < bestHorizCounter; i++)
                {
                    Console.Write("{0}, ", matrix[horizRow, horizCol]);
                }
                
            }
            if (bestVertCounter > bestHorizCounter && bestVertCounter > bestDiagCounter && bestVertCounter > bestLeftDiagCounter)
            {
                Console.WriteLine();
                for (int i = 0; i < bestVertCounter; i++)
                {
                    Console.Write("{0}, ", matrix[vertRow, vertCol]);
                }
		        
	        }
            if (bestLeftDiagCounter > bestHorizCounter && bestLeftDiagCounter > bestDiagCounter && bestLeftDiagCounter > bestVertCounter)
            {
                Console.WriteLine();
                for (int i = 0; i < bestLeftDiagCounter; i++)
                {
                    Console.Write("{0}, ", matrix[leftDiagRow, leftDiagCol]);
                }
                
            }
        }
        
    }
}






















//string[,] matrix = { { "ha", "fifi", "ho", "hi" }, { "fo", "ha", "hi", "xx" }, { "xxx", "ho", "ha", "xx" } };
//int horizontCount = 0;
//int bestHorizCnt = 0;
//int horizRow = 0;
//int horizCol = 0;
//int vertCount = 0;
//int bestVertCnt = 0;
//int vertRow = 0;
//int vertCol = 0;
//int diagCount = 0;
//int bestDiagCnt = 0;
//int diagRow = 0;
//int diagCol = 0;

//for (int row = 0; row < 3; row++)
//{
//    for (int col = 0; col < 4; col++)
//    {
//        if (matrix[row, col] == matrix[row, col + 1])
//        {
//            while (matrix[row, col] == matrix[row, col + 1] && col < 4-1)
//            {
//                horizontCount++;
//                if (horizontCount > bestHorizCnt)
//                {
//                    bestHorizCnt = horizontCount;
//                    horizCol = col;
//                    horizRow = row;
//                }
//                col++;
//            }
//        }

//        if (matrix[row, col] == matrix[row + 1, col] && row < 3-1)
//        {
//            while (matrix[row, col] == matrix[row + 1, col])
//            {
//                vertCount++;
//                if (vertCount > bestVertCnt)
//                {
//                    bestVertCnt = vertCount;
//                    vertCol = col;
//                    vertRow = row;
//                }
//                row++;
//            }
//        }
//        if (matrix[row, col] == matrix[row + 1, col + 1])
//        {
//            while (matrix[row, col] == matrix[row + 1, col + 1] && row < 3-2 && col < 4-2)
//            {
//                diagCount++;

//                if (diagCount > bestDiagCnt)
//                {
//                    bestDiagCnt = diagCount;
//                    diagCol = col;
//                    diagRow = row;
//                }
//                row++;
//                col++;
//            }
//        }


//    }
//}