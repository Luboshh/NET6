using System;
using System.Collections.Generic;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // načíst lidi ze souboru do listu
            //a vypsat nactene lidi do konzole

            Console.WriteLine(ReadPeopleFromFile);
        }

        static void ReadPeopleFromFile()
        {
            List<Person> people = new List<Person>()

        }

        private static void SavePeopleToFile()
        {
            List<Person> people = new List<Person>();

            var p1 = new Person("Adam", "Smith", 44);
            var p2 = new Person("Jane", "Doe", 54);
            var p3 = new Person("Jan", "Novák", 34);
            var p4 = new Person("Marie", "Dolejší", 27);

            people.Add(p1);
            people.Add(p2);
            people.Add(p3);
            people.Add(p4);

            string file = "people.txt";

            foreach (var p in people)
            {
                // FirstName;LastName;Age
                var personAsString =
                    $"{p.FirstName};{p.LastName};{p.Age}{Environment.NewLine}";

                File.AppendAllText(file, personAsString);
            }

            Console.WriteLine($"ulozeno do souboru {file}");
        }

        static void PersonActions()
        {
            Person p1 = new Person("Adam", "Smith", 30);

            Person alice = new Person("Alice", "Smith", 30);

            Console.WriteLine($"osoba 1: {p1}");
            Console.WriteLine($"osoba 2: {alice}");
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

    }
}