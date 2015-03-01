//Problem 21. Letters count
//Write a program that reads a string from the console and prints all different letters 
//in the string along with information how many times each letter is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LettersCount
{
    static void Main()
    {
//        string textinput = @"Lorem ipsum dolor sit amet, et eget rutrum justo, pellentesque malesuada 
//lorem risus lectus sit, ante egestas ut orci, aliquam est, a suspendisse enim fusce. 
//Mi fermentum mauris iaculis nullam augue, vel vulputate sit. Odio suspendisse duis dictum, 
//mauris phasellus vestibulum. Magna nunc malesuada metus et, massa elit sit lorem libero, 
//erat arcu curabitur elit, luctus fermentum, ac tempor. Orci vivamus a et nec, volutpat a, 
//conubia lacus mi. Placerat lectus purus vehicula rhoncus, praesent enim eget, non enim. 
//In odio tortor ut sagittis morbi magna, mauris nec vitae ligula elit amet metus, nunc tristique in nonummy massa.";
        Console.WriteLine("input text");
        string textinput = Console.ReadLine();
        
        string text = textinput.ToLower();
        char[] letters = new char[500];
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                letters[text[i]]++;
            }
        }
        for (int i = 0; i < letters.Length; i++)
        {
            if (char.IsLetter((char)i) && letters[i] > 0)
            {
                Console.WriteLine("'{0}'- {1} times", (char)i, (int)letters[i]);
            }
        }

    }
}