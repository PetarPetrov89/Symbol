using System;
using System.Linq;

namespace WordsWithComma
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] words = text.Split(',', StringSplitOptions.RemoveEmptyEntries);

            string[] ordered = words.OrderBy(w => w,
                StringComparer.OrdinalIgnoreCase).ToArray();

            Console.WriteLine(string.Join(", ", ordered));
        }
    }
}
