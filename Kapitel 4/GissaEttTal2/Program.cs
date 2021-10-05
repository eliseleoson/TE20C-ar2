using System;

namespace GissaEttTal2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Spelet Gissa ett tal!!");

            // Slumpa fram ett tal
            Random tärning = new Random ();
            int slumptal = tärning.Next(1, 51);

            // Loopa 5 gånger
            int räknare = 0;
            while (true)
            {
                // Räknar upp varv
                räknare++;

                // Bryt efter 5 varv
                if (räknare >= 6)
                {
                    break;
                }

                // Fråga användaren om en gissning
                Console.Write("Gissa ett tal (1-50): ");
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
