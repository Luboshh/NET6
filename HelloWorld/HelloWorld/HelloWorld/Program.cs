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

        
    }

}
