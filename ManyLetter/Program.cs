using System;
using System.Text;

namespace ManyLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                char currEl = text[i];


                if (currEl != text[i-1])
                {
                    sb.Append(currEl);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
