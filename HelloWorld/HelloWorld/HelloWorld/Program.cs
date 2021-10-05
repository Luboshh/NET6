using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10, 20);

        }

        static void PersonActions()
        {
            // ukol je vytvorit konstruktor pro Person
            // ktery bere i vek

            Person p1 = new Person("Adam", "Smith", 30);

            Person alice = new Person("Alice", "Smith", 30);

            Console.WriteLine($"osoba 1: {p1}");
            Console.WriteLine($"osoba 2: {alice}");
        }



        private static int ReadNumber()
        {
            return int.Parse(Console.ReadLine());
        }


    }
}
