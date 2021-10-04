using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;


            Console.WriteLine($"a: {a}, b: {b}");

            var A = b;
            var B = a;

            Console.WriteLine($"a: {A}, b: {B}");

        }


    }
}