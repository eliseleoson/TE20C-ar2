using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Gissa ett tal");

            // Slumpgenerator
            Random generator = new Random();

            // Slumpar fram ett tal
            int slumptal = generator.Next(1, 101); // 1-100
            int slumptal2 = generator.Next(1, 11); // 1-10

            // Försök översätta det inmatade till ett tal
            // TryParse gör att man kan skriva in text som svar och inte krascha programmet
            int gissningTal = 0;
            bool korrekt = false;

            // Loopa för att tvinga ett korrekt svar
            while (korrekt != true)
            {
                Console.Write("Gissa ett tal (1-100): ");
                string gissning = Console.ReadLine();
                korrekt = int.TryParse(gissning, out gissningTal);
            }


            // Var gissningen rätt
            if (gissningTal == slumptal)
            {
                Console.WriteLine("Du gissade rätt!");
            }
            else
            {
                Console.WriteLine("Du gissa fel");
            }
        }
    }
}
