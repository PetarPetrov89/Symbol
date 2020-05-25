using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Symbol_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "C#";
            string word2 = "c#";

            Console.WriteLine(word1.Equals("C#"));
            Console.WriteLine(word1.Equals(word2, 
                StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(word1 == "C#");
            Console.WriteLine(word1 == word2);

            //Лексикогравско сравнение.
            string score = "sCore";
            string scary = "scary";

            Console.WriteLine(score.CompareTo(scary));
            Console.WriteLine(scary.CompareTo(score));
            Console.WriteLine(scary.CompareTo(scary));


            //Търсене в Стринг.

            string book = "Lord of the Ring";

            int index = book.IndexOf("of");

            var subString = book.Substring(5,4);

            int lastIndex = book.LastIndexOf("of");

            bool result = book.EndsWith("of");


            Console.WriteLine(index);
            Console.WriteLine(subString);
            Console.WriteLine(lastIndex);
            Console.WriteLine(result);

            //1
            //Фактура  0000000001/04.05.2020г.

            string invoiceNum = "356";

            string invoiceNumPadded = invoiceNum.PadLeft(10, '0');

            Console.WriteLine(invoiceNumPadded);

            //
            string[] words = book.Split(" ");

            Console.WriteLine(string.Join(",", words));




            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Do you want to.......");
            string response = Console.ReadLine();

            string firstPhrase = "Lord of the rings";
            string secondPhrase = "Is my favourite book";
            string thirdPhrase = "Its Autor is";

            sb.AppendLine(firstPhrase);
          

            if (response == "yes")
            {
                sb.AppendLine(secondPhrase);
            }
            sb.AppendLine(thirdPhrase);
            Console.WriteLine(sb.ToString());

            Console.WriteLine(sb.Length);
                
                }
    }
}
