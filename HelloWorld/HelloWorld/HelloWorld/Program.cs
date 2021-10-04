using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte Vaše jméno");

            var input = Console.ReadLine();

            Console.WriteLine($"Hello {input}");
           

        }

    }
}