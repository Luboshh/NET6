using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -2079, -498, 2920, -1856, 332, -2549, -674, -120, -992, 2782, 320, -524, 135, 952, 1868, 2509, -230, -138, -904, -480 };

            /// z "numebers" zjistěte:
            /// 1. počet prvků v poli
            /// 2. největší hodnotu
            /// 3. nejmenší hodnotu
            /// 4. průměr
            /// 5. kolik obsahuje pole kladných čísel
            /// 6. kolik obsahuje pole záporných čísel
            /// 7. sumu všech hodnot
            /// 8. sumu kladných hodnot


            ////// projection / restrikce / filtrovani - Where

            /// 9. všechna čísla větší než -500
            /// 10. všechna kladná sudá čísla
            /// 11. čísla v rozstahu -400 až 400


            //foreach (var item in ordered)
            //{
            //    Console.WriteLine(item);
            //}
        }

        static List<Person> LoadPeople(string file)
        {
            List<Person> people = new List<Person>();
            string[] lines = File.ReadAllLines(file);

            foreach (var line in lines)
            {
                // FirstName;LastName;Age
                string[] items = line.Split(';');

                var first_name = items[0];
                var last_name = items[1];
                var age = int.Parse(items[2]);

                var p = new Person(first_name, last_name);
                people.Add(p);
            }
            return people;
        }

        static void TuplesAndExceptions()
        {
            try
            {
                var number = int.Parse(Console.ReadLine());
                var x = number / 0;
                Console.WriteLine($"zadal jsi číslo {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Nemohu převést řetězec na číslo");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("dělíme nulou");
            }

            bool succ;
            int val;

            // ulozeni tuplu to Tuple typu
            var tupleResult = MyTryParse("150.0");
            succ = tupleResult.Item1;
            val = tupleResult.Item2;

            // ulozeni tuplu to Tuple typu - pojmenovane itemy
            tupleResult = MyTryParse("150.0");
            succ = tupleResult.success;
            val = tupleResult.value;

            // rozlozeni tuplu primo do promennych
            (succ, val) = MyTryParse("150.0");

        }

        static (bool success, int value) MyTryParse(string input)
        {
            return (success: true, value: 10);
        }

        private static int ReadNumber()
        {
            return int.Parse(Console.ReadLine());
        }

        private static void Interfaces()
        {
            INamed st = new Student() { Name = "Student Pepa" };
            INamed teacher = new Teacher() { Name = "Učitel Marek" };
            INamed person = new Person() { Name = "Osoba" };

            PrintName(st);
            PrintName(teacher);
            PrintName(person);
        }
        private static void PrintName(INamed item)
        {
            item.Print();
        }

    }
}