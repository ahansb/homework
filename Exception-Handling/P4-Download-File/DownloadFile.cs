//Problem 4. Download file
//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;


class DownloadFile
    {
        static void Main()
        {
            WebClient webClient = new WebClient();
            try
            {
                webClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", @"..\..\image.png");
                Console.WriteLine( "Download suxAssFull");
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid URL!");
            }
        }
    }