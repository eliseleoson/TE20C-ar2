using System;

namespace Villkor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frågar om användarens ålder
            Console.Write("Hur gammal är du? ");
            int ålder = int.Parse (Console.ReadLine());

            //Om ålder > än 18 du får ta körkort
            if (ålder >= 18)
            {
                Console.WriteLine("Du får ta körkort!");
            }
            
            //Om ålder är 15 eller högre --> "Du får ta mopedkörkort!"
            if (ålder >= 15)
            {
                Console.WriteLine("Du får ta mopedkörkort!");
            }

            // Fråga användaren "Vad heter ABBAs senaste album?"
            Console.Write("Vad heter ABBAs senaste album? ");
            string låt = Console.ReadLine();
            
            //Är svaret korrekt?
            if (låt == "Voyage" || låt == "voyage")
            {
                Console.WriteLine("Svaret är rätt!");
            }
            else
            {
               Console.WriteLine("Fel! Albumet heter Voyage"); 
            }

            //Siste TP-fråga
            Console.Write("Vem missade straffen i matchen England/Frankrike(efternamn) ");

            //Läs in och tvinga till små bokstäver
            //Mbappe --> mbappe
            string spelare = Console.ReadLine().ToLower();

            if (spelare == "Mbappe")
            {
                Console.WriteLine("Bra, du är en expert!");
            }
            else
            {
                Console.WriteLine("Fel! Det var Mbappe");
            }
        }
    }
}
