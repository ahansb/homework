//Problem 3. English digit
//Write a method that returns the last digit of given integer as an English word.

using System;
class EnglishDigit
{
    static void Main()
    {
        Console.WriteLine("Input number:");
        int number = int.Parse(Console.ReadLine());
        string word = LastDigitWord(number);
        Console.WriteLine(word);
    }

    static string LastDigitWord(int number)
    {
        string lastWord="";
        switch (number % 10)
        {
            case 0:  lastWord = "zero"; break;
            case 1:  lastWord = "one"; break;
            case 2:  lastWord = "two"; break;
            case 3:  lastWord = "three"; break;
            case 4:  lastWord = "four"; break;
            case 5:  lastWord = "five"; break;
            case 6:  lastWord = "six"; break;
            case 7:  lastWord = "seven"; break;
            case 8:  lastWord = "eight"; break;
            case 9:  lastWord = "nine"; break;
                
        }
        return lastWord;
    }
}