using System;

namespace Symbol
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello World! How are you?";

            Console.WriteLine($"word = {word}");
            Console.WriteLine($"word.Lenght = {word.Length}");

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"word[{i}] = {word[i]}");
            }
            char ch = word[0];

            Console.WriteLine(ch);
        }
    }
}
