using System;

namespace Uppgift_4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Frågar användaren vilket land är störst i Europa
            Console.WriteLine("Vilket är Europas största land?");
            string svar = Console.ReadLine();
            int antalGissningar = 1;

            while (svar != "Ryssland")
            {
                // Det får inte vara fler än 5 gissningar
                if (antalGissningar >= 5)
                {
                    Console.WriteLine("Dina gissningar är slut");
                    break;
                }
                Console.WriteLine("Fel svar, försök igen");
                svar = Console.ReadLine();
                antalGissningar++;
            }

            if (svar == "Ryssland")
            {
                Console.WriteLine("Ditt svar är rätt!");
            }
        }
    }
}
