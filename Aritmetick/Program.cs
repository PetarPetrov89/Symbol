using System;

namespace Aritmetick
{
    class Program
    {
        static void Main(string[] args)
        {
            string aritmetic = Console.ReadLine();

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < aritmetic.Length; i++)
            {
                if (aritmetic[i] == ')')
                {
                    sum1++;
                }
                else if (aritmetic[i] == '(')
                {
                    sum2++;
                }

            }
            if (sum1 != sum2)
            {
                Console.WriteLine("Invalid");
                return;
            }

            int openIndex = aritmetic.IndexOf('(');
            int closeIndex = aritmetic.IndexOf(')');

            if (openIndex > closeIndex)
            {
                Console.WriteLine("Invalid");
                return;
            }

            for (int i = 0; i < aritmetic.Length; i++)
            {
                if (aritmetic[i] == '(')
                {
                    int isThereClosing = aritmetic.IndexOf(')', i);

                    if (isThereClosing == 0)
                    {
                        Console.WriteLine("Invalid");
                        return;

                    }
                }
            }
            Console.WriteLine("Valid");
        }
    }
}
