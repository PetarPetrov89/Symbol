using System;
using System.Linq;
using System.Text;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            //option 1
            var reversed = word.Reverse();


            Console.WriteLine(string.Join("",reversed));

            //option 2
            char[] wordArr = word.ToCharArray();

            Console.WriteLine(string.Join("", reversed));

        }
    }

}
