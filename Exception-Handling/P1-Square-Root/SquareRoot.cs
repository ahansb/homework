//Problem 1. Square root
//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

using System;

 class SquareRoot
    {
        static void Main()
        {
            Console.WriteLine("Input positive int number");
            string number = Console.ReadLine();
            try
            {
                var num = UInt32.Parse(number);
                Console.WriteLine(
                   "You entered valid UInt32 number {0}.", number);
                Console.WriteLine("the square root is: {0}",Math.Sqrt(num));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer positive number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine(
                   "The number is too big or negative to fit in UInt32!");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }

            
        }
    }