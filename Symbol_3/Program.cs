using System;

namespace Symbol_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "Some source";
            string assigned = source;

            Pet kotka = new Pet() { Name = "Gosho", Age = 13 };

            Pet kotka2 = kotka;

            kotka.Name = "Pesho";
            Console.WriteLine(kotka2.Name);

            string hello = "Hello";
            string world = "World";

            string firstWay = hello + " " + world;

            string secondWay = string.Format("{0} {1}", hello, world);

            string thirdWay = $"{hello} {world}";

            Console.WriteLine(firstWay);
            Console.WriteLine(secondWay);
            Console.WriteLine(thirdWay);

        }
    }
    public class Pet
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
