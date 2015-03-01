//Problem 7. Encode/decode
//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string 
//with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EncodeDecode
{
    static void Main()
    {
        Console.WriteLine("input text to encode");
        //string inputText = "ABCDEeeee";
        string inputText = Console.ReadLine();
        
        Console.WriteLine("input key");
        string key = Console.ReadLine();
        
        //string key = "ABCD";
        string result = EncodeDecodeTxt(inputText, key);
        Console.WriteLine("encoded : {0}",result);
        string backToTxt = EncodeDecodeTxt(result, key);
        Console.WriteLine("decoded: {0}",backToTxt);
        
    }

    static string EncodeDecodeTxt(string inputText, string key)
        {
            StringBuilder decoded = new StringBuilder();
            for (int i = 0; i < inputText.Length; i++)
            {
                decoded.Append((char)(inputText[i] ^ key[i % key.Length]));
            }
            string result = decoded.ToString();
            return result;
        }

   
}