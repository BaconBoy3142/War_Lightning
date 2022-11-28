using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Lightning
{
    internal class Program
    {
        static string[] story;
        static void Main(string[] args)
        {
            string storyTxt = "Story.txt";
            string[] storyLines = File.ReadAllLines(storyTxt);
            Console.WriteLine(storyLines[0]);
            Console.ReadKey(true);
        }
    }
}
