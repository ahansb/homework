//Problem 13. Solve tasks

//    Write a program that can solve these tasks:
//        Reverses the digits of a number
//        Calculates the average of a sequence of integers
//        Solves a linear equation a * x + b = 0
//    Create appropriate methods.
//    Provide a simple text-based menu for the user to choose which task to solve.
//    Validate the input data:
//        The decimal number should be non-negative
//        The sequence should not be empty
//        a should not be equal to 0

using System;
using System.Collections.Generic;
using System.Linq;
class SolveTasks
    {
        static void Main()
        {
            Console.WriteLine("Reverses the digits of a number - Press [1]");
            Console.WriteLine("Calculates the average of a sequence of integers - Press [2]");
            Console.WriteLine("Solves a linear equation a * x + b = 0 - Press [3]");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Input positive decimal number to reverse it:");
                string number = Console.ReadLine();
                int num = int.Parse(number);
                if (num<0)
                {
                    Console.WriteLine("The number should be non-negative!!!");
                }
                else
                Console.WriteLine(ReverseString(number));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter integers sepparated by space:");
                string check = Console.ReadLine();
                if (check == "")
                {
                    Console.WriteLine("Input some integer!!!");
                }
                else
                {
                    int[] numbers = check.Split(' ').Select(x => int.Parse(x)).ToArray();
                    Console.WriteLine("The average is {0}",numbers.Average());
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Input a:");
                int a = int.Parse(Console.ReadLine());
                if (a==0)
                {
                    Console.WriteLine("a should differ from 0!!!");
                }
                else
                {
                    Console.WriteLine("Input b:");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("x = {0}", SolveLinearEquat(a, b)); 
                }
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }

        static decimal SolveLinearEquat(decimal a, decimal b)
        {
            decimal x = -(b / a);
            return x;
        }
        static char[] ReverseString(string number)
        {
            var reverse = number.Reverse().ToArray();
            return reverse;
        }
        
    }