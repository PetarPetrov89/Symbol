using System;
using System.Linq;
using System.Text;

namespace Alphabetic
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] separator = new char[] { ' ', '\t', '\n', ',', '!', '.', '?', ';', ':' };

            string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            string[] ordered = words.OrderBy(w => w, StringComparer.Ordinal).ToArray();
            Console.WriteLine(string.Join(", ", ordered));

            var counts = words.GroupBy(w => w).Select(g => new { Word = g.Key, Count = g.Count() }).ToList();

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Word} - {item.Count}");
            }
        }
    }
}
