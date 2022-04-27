using System;

namespace Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Skapa en array med 10 platser
            string [] platser = new string[10];

            // Fylla arrayen
            for (int i = 0; i < platser.Length; i++)
            {
                Console.Write("Ange en plats: ");
                string plats = Console.ReadLine();
                platser[i] = plats;   
            }

            // Skriv ut arrayens innehåll
            foreach (var plats in platser)
            {
                Console.WriteLine(plats);
            }

            // Skriv ut alla med stora bokstäver
            foreach (var plats in platser)
            {
                Console.WriteLine(plats.ToUpper());
            }

        }
    }
}
