using System;

namespace Prov3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Program for listing countries!");

            // Array of countries
            string[] countries = { "Andorra", "Afghanistan", "Antigua och Barbuda", "Bulgarien", "Vitryssland", "Benin", "Chile", "Kina", "Dominikanska republiken", "Eritrea", "Indonesien", "Kirgizistan", "Liechtenstein", "Madagaskar", "Papua Nya Guinea" };

            // Length of shortest country
            int minlength = 4;
            // Length of longest country
            int toplength = 0;

            // Calculate toplength
            foreach (var country in countries)
            {
                if (toplength <= country.Length)
                {
                    toplength = country.Length;
                }
            }

            // max lenght for names
            int maxlength = 0;

            while (true)
            {
                // User inputs max length
                Console.Write("Please put in max length: ");
                maxlength = InputInt(minlength, toplength);

                // Output countries
                outputcountries(maxlength, countries);

                // One more time?
                Console.Write("Do you want to try again? (y/n) ");
                if (Console.ReadLine() == "n")
                {
                    break;
                }
            }

        }

        // Method for input
        static int InputInt(int minlength, int toplength)
        {
            int Number = 0;

            while (true)
            {
                // 1. Make sure user inputs an int
                while (!int.TryParse(Console.ReadLine(), out Number))
                {
                    Console.Write("You have to put in a number! Please try again: ");
                }

                // 2. Make sure user inputs number between 4 and 22
                if (Number < 4 || Number > 23)
                {
                    Console.Write("You have to put in a number between 4 and 22! Please try again: ");
                }
                else
                {
                    break;
                }
            }

            return Number;
        }

        static void outputcountries(int maxlength, string[] countries)
        {
            // output countries
            foreach (var country in countries)
            {
                if (country.Length <= maxlength)
                {
                    Console.WriteLine($"* {country}");
                }

            }
        }
    }
}
