using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // uzivatel an vstup zada teplotu ve st. F
            // a program prevede a vypise teplotu ve st C
            // metoda
            // cteni z konzole, prevod na cislo
            // C = (F - 32) / 1.8

            TempCalcs.PrintAndConvertTemp();

        }

    }
}