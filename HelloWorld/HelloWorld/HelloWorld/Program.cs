using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // úkol:
            // uživatel zadá rok narození a program
            // mu vypíše do jaké patří generace

            // Baby Boomerss — born 1946 - 1964
            // Generation X — born 1965 - 1980
            // Millenials — born 1981 - 1996
            // Generation Z — born 1997 - 2012
            // Generation Alpha — born 2013 -

            Console.WriteLine("Zadejte svůj rok narození: ");
            string input = Console.ReadLine();
            var year = int.Parse(input);

            var gen_urceni = UrceniGenerace(year);
            Console.WriteLine($"Gen: {gen_urceni}");
        }

        static string UrceniGenerace(int year)
        {
            if (year > 1946 && year < 1964)
            return "Baby Boomer";
            if (year > 1965 && year < 1980)
            return "Generation X";
            if (year > 1981 && year < 1996)
            return "Millenials";
            if (year > 1997 && year < 2021)
            return "Generation Z";
            if (year >= 2013)
            return "Gen Aplpha";
            else
                return $"Neznám název generace pro rok {year}";
        }
    }
}