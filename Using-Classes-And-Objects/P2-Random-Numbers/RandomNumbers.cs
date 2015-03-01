//Problem 2. Random numbers
//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
 class RandomNumbers
    {
        static Random rand = new Random();
        static void Main()
        {

            int lenght = 10;
            int lowBord = 100;
            int upBord = 200;
            
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine(rand.Next(lowBord, upBord+1));
            }
        }
    }