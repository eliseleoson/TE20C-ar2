using System;

namespace BoolskaUttryck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coronasymptom");

            Console.WriteLine("Har du feber? (ja/nej)");
            string feber = Console.ReadLine();

            Console.WriteLine("Hostar du? (ja/nej)");
            string hosta = Console.ReadLine();

            Console.WriteLine("Har du tappat smaken? (ja/nej)");
            string smak = Console.ReadLine();

            Console.WriteLine("Är du vaccinerad? (ja/nej)");
            string vaccin = Console.ReadLine();

            // Om dessa tre villkor är uppfyllda
            /* if (feber == "ja" && hosta == "ja" && smak == "ja")
            {
                Console.WriteLine("Du har troligen Covid-19");
            }
            
            if (hosta == "ja" && smak =="ja")
            {
                Console.WriteLine("Du har troligen Covid-19");
            }
            
            if (feber == "ja" && smak =="ja")
            {
                Console.WriteLine("Du har troligen Covid-19");
            } */

            if (feber == "ja" || hosta == "ja" && smak == "ja")
            {
                Console.WriteLine("Du har troligen Covid-19");
            }
        }
    }
}
