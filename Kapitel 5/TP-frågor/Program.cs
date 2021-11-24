using System;

namespace TP_frågor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Slumpa fram en fråga");

            // Namn ge korten (array)
            string[] korten = {
                "När uppfördes Verdi?", // 0
                "Vem vann fotbolls-EM 1984?", // 1
                "Vem skrev Frankenstein?", // 2
                "Vad är 5+5?", // 3
                "När startade andra världskriget?", // 4 
                "Vem är president i USA 2021?" // 5
                };

            // Kasta tärningen
            Random tärning = new Random();
            int slumptal = tärning.Next(0, 6); // 0-5

            // Skriver utslaget
            Console.WriteLine($"Tärningen slog {slumptal}");

            // Skriv ut fråga
            Console.WriteLine($"Frågan: {korten[slumptal]}");
        }
    }
}
