//Problem 12. Parse URL
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and
//extracts from it the [protocol], [server] and [resource] elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ParseURL
    {
        static void Main()
        {
            //string url = "http://telerikacademy.com/Courses/Courses/Details/212";
            Console.WriteLine("input url");
            string url = Console.ReadLine();
            
            string[] extract = ExtractUrl(url);
            Console.WriteLine("[protocol] = {0}",extract[0]);
            Console.WriteLine("[server] = {0}", extract[1]);
            Console.WriteLine("[resource] = {0}", extract[2]);
        }

        static string[] ExtractUrl(string url)
        {
            string[] result= new string[3];
            int idxDPoint = url.IndexOf(':');
            result[0] = url.Substring(0, idxDPoint);
            int idxServStart = url.IndexOf("//")+2;
            int idxServEnd = url.IndexOf("/",idxServStart);
            result[1] = url.Substring(idxServStart, idxServEnd- idxServStart);
            result[2] = url.Substring(idxServEnd, url.Length - idxServEnd);
            
            return result;
        }
    }