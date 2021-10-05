using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.FirstName = "Adam";
            p1.LastName = "Smith";
            p1.Age = 30;

            Console.WriteLine($"Osoba 1: {p1.GetFullName()}");

        }



    }
}
