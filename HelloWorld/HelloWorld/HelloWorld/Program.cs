using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toto je prvni prikaz ktery se vykona po spusteni aplikace.");
            Hello();
            int sum = Add(5, 3);
            Console.WriteLine(sum);
            int sum2 = AddAndPrint(4, 9);
        }

        static int AddAndPrint(int a,int b)
        {
            return a + b;
        }

        static void Hello()
        {
            Console.WriteLine("Hello");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}