//Problem 12. Subtracting polynomials
//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;

class SubtractingPolynomials
{
    static void Main()
    {
        int[] polynomOne = { 1, 2, 3, 5, 3 };
        int[] polynomTwo = { 4, 5, 6, -7 };

        PrintPolynom(polynomOne);
        Console.WriteLine();
        PrintPolynom(polynomTwo);
        Console.WriteLine();
        PrintPolynom(SumPolynom(polynomOne, polynomTwo));
        Console.WriteLine();
        PrintPolynom(SubtractPolynom(polynomOne, polynomTwo));
        Console.WriteLine();
        PrintPolynom(MultiplyPolynom(polynomOne, polynomTwo));


    }

    static int[] MultiplyPolynom(int[] polynomOne, int[] polynomTwo)
    {
        if (polynomTwo.Length > polynomOne.Length)
        {
            int[] polynomMultiply = new int[polynomTwo.Length];
            for (int i = polynomOne.Length - 1; i >= 0; i--)
            {
                polynomMultiply[i] = polynomOne[i] * polynomTwo[i];
            }
            for (int i = polynomTwo.Length - 1; i > polynomOne.Length - 1; i--)
            {
                polynomMultiply[i] = polynomTwo[i];
            }
            return polynomMultiply;
        }
        else if (polynomTwo.Length < polynomOne.Length)
        {
            int[] polynomMultiply = new int[polynomOne.Length];
            for (int i = polynomTwo.Length - 1; i >= 0; i--)
            {
                polynomMultiply[i] = polynomOne[i] * polynomTwo[i];
            }
            for (int i = polynomOne.Length - 1; i > polynomTwo.Length - 1; i--)
            {
                polynomMultiply[i] = polynomOne[i];
            }
            return polynomMultiply;
        }
        else
        {
            int[] polynomMultiply = new int[polynomOne.Length];
            for (int i = polynomOne.Length - 1; i >= 0; i--)
            {
                polynomMultiply[i] = polynomOne[i] * polynomTwo[i];
            }

            return polynomMultiply;
        }
    }

    static int[] SubtractPolynom(int[] polynomOne, int[] polynomTwo)
    {
        if (polynomTwo.Length > polynomOne.Length)
        {
            int[] polynomSubtract = new int[polynomTwo.Length];
            for (int i = polynomOne.Length - 1; i >= 0; i--)
            {
                polynomSubtract[i] = polynomOne[i] - polynomTwo[i];
            }
            for (int i = polynomTwo.Length - 1; i > polynomOne.Length - 1; i--)
            {
                polynomSubtract[i] = polynomTwo[i];
            }
            return polynomSubtract;
        }
        else if (polynomTwo.Length < polynomOne.Length)
        {
            int[] polynomSubtract = new int[polynomOne.Length];
            for (int i = polynomTwo.Length - 1; i >= 0; i--)
            {
                polynomSubtract[i] = polynomOne[i] - polynomTwo[i];
            }
            for (int i = polynomOne.Length - 1; i > polynomTwo.Length - 1; i--)
            {
                polynomSubtract[i] = polynomOne[i];
            }
            return polynomSubtract;
        }
        else
        {
            int[] polynomSubtract = new int[polynomOne.Length];
            for (int i = polynomOne.Length - 1; i >= 0; i--)
            {
                polynomSubtract[i] = polynomOne[i] - polynomTwo[i];
            }

            return polynomSubtract;
        }
    }

    static int[] SumPolynom(int[] polynomOne, int[] polynomTwo)
    {

        if (polynomTwo.Length > polynomOne.Length)
        {
            int[] polynomSum = new int[polynomTwo.Length];
            for (int i = polynomOne.Length - 1; i >= 0; i--)
            {
                polynomSum[i] = polynomOne[i] + polynomTwo[i];
            }
            for (int i = polynomTwo.Length - 1; i > polynomOne.Length - 1; i--)
            {
                polynomSum[i] = polynomTwo[i];
            }
            return polynomSum;
        }
        else if (polynomTwo.Length < polynomOne.Length)
        {
            int[] polynomSum = new int[polynomOne.Length];
            for (int i = polynomTwo.Length - 1; i >= 0; i--)
            {
                polynomSum[i] = polynomOne[i] + polynomTwo[i];
            }
            for (int i = polynomOne.Length - 1; i > polynomTwo.Length - 1; i--)
            {
                polynomSum[i] = polynomOne[i];
            }
            return polynomSum;
        }
        else
        {
            int[] polynomSum = new int[polynomOne.Length];
            for (int i = polynomOne.Length - 1; i >= 0; i--)
            {
                polynomSum[i] = polynomOne[i] + polynomTwo[i];
            }

            return polynomSum;
        }

    }

    static void PrintPolynom(int[] polynom)
    {
        string separator = string.Empty;
        for (int i = polynom.Length - 1; i >= 0; i--)
        {
            if (polynom[i] >= 0)
            {
                Console.Write(separator);
            }

            Console.Write("{0}x^{1}", polynom[i], i);

            separator = "+";
        }
        Console.WriteLine();
    }
}

