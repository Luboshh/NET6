using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // úkol:
            // metodu (switch case) která dostance na vstup
            // číslo 1 - 7 a vrátí název dne pondělí...neděle

            var daynumber = 5;
            var dayname = GetDayName(daynumber);
            Console.WriteLine($"{daynumber}. den je {dayname}");
        }

        static string GetDayName(int day)
        {
            switch (day)
            {
                case 1:
                    return "pondělí";
                    break;
                case 2:
                    return "úterý";
                    break;
                case 3:
                    return "středa";
                    break;
                case 4:
                    return "čtvrtek";
                    break;
                case 5:
                    return "pátek";
                    break;
                case 6:
                    return "sobota";
                    break;
                case 7:
                    return "neděle";
                    break;
                default:
                    return "neznámý den";
                    break;
            }
        }

        static string GetGenerationName(int year)
        {
            if (year > 1946 && year <= 1964)
                return "Baby Boomer";
            else if (year >= 1965 && year <= 1980)
                return "Gen X";
            else if (year >= 1981 && year <= 1996)
            {
                return "Millenial";
            }
            else if (year >= 1997 && year <= 2012)
                return "Gen Z";
            else if (year >= 2013)
                return "Gen Alpha";
            else
                return $"neznám název generace pro rok {year}";
        }
    }
}
