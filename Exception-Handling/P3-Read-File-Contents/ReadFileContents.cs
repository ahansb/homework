//Problem 3. Read file contents
//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
class ReadFileContents
{
    static void Main()
    {
        try
        {
            var sr = new StreamReader(@"..\..\TextFile.txt");
            using (sr)
            {
                string fromSR = sr.ReadToEnd();
                Console.WriteLine(fromSR);
            }
            
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Invalid FILE PATH!");
        }
        catch (IOException)
        {
            Console.WriteLine("The file is used by another program!");
        }

    }
}
