using System;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Presenterar programmet
            Console.WriteLine("Program för Ceasar-kryptering");

            // Ber användaren om ord
            Console.Write("Skriv ett meddelande: ");
            string ord = Console.ReadLine();
            
            // Frågar användaren hur många steg man ska hoppa 1-9
            Console.Write("Ange en nyckel (1-9): ");
            int nyckel = int.Parse(Console.ReadLine());
            
            string meddelandeKrypterad = "";

            // Loopar ordet för varje bokstav
            for (int i = 0; i < ord.Length; i++)
            {
                // Skriver bokstaven en i taget
                char bokstav = ord[i];

                // ASCII kod
                int kod = (int)bokstav;

                // Lägg till nyckeln
                kod += nyckel;

                // Tecken av ASCII-kod
                char bokstavKrypterad = (char)(kod);

                meddelandeKrypterad += bokstavKrypterad.ToString();

                // Ceasar kryptering
                Console.WriteLine($"{ord} blir {meddelandeKrypterad} ");

            }
        }
    }
}
