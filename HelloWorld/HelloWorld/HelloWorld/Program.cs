using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point("10.234", "234.3403");
            Console.WriteLine($"Souřadnice GPS: {p1.GetFullGPS()}");
            //Person p1 = new Person("Adam", "Smith", 30);
            //Console.WriteLine($"Osoba 1: {p1.GetFullName()}");
        }



    }
}
