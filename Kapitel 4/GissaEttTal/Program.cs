using System;

namespace Gissa_ett_nummer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Spel - Gissa ett nummer 1-100");

            // Slumpa fram ett tal
            Random tärning = new Random ();
            int slumptal = tärning.Next(1, 101);

            // Upprepa frågan
            int räknare = 0;
            while (true)
            {
                // Räknar antal gissningar = varv
                räknare++;

                // Fråga användaren om en gissning
                Console.Write("Gissa ett tal (1-100): ");
                int gissning = int.Parse(Console.ReadLine());

                // Är gissningen rätt?
                if (gissning == slumptal)
                {
                    Console.WriteLine($"Bra gissat! Du hade rätt! Du gjorde det på {räknare} försök");
                    break;
                }
                
                // Jämför med slumptal
                if (gissning < slumptal)
                {
                    Console.WriteLine("För lågt");
                }
                else
                {
                    Console.WriteLine("För högt");
                }   

            }
        }
    }
}
