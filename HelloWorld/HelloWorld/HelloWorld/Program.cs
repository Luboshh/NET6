using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //napiste metodu která na vstupu dostane dve cela cisla a vrátí vetší z nich a pekně vytisknout

            const int c = 20300;
            const int d = 20394;

            var a = 24054;
            var b = 20949;

            if (a > b)
            {
                Console.WriteLine("A je větší");
            }
            else if (a == c)
                Console.WriteLine("A je větší");
            else if (a == d)
                Console.WriteLine("A je větší");
            else
                Console.WriteLine("A není větší");

        }



            
        

    }
}