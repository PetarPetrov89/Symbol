using System;

namespace SplitText
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Hello\World\How\Are\you";

            string[] word = text.Split('\\');

            Console.WriteLine(string.Join(',', word));
        }
    }
}
