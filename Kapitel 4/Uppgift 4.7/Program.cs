using System;

namespace Uppgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv din summa
            Console.WriteLine("Skriv din summa ");
            String summaText = Console.ReadLine();

            // Loopa igenom summaText
            int summa = 0;
            for (int i = 0; i < summaText.Length; i++)
            {
                char siffra = summaText[i];
                Console.WriteLine(siffra);
                
                // Omvandla char -> string -> int
                // Omvandla char med .ToString()
                int siffraTal = int.Parse(siffra.ToString());

                // Addera till summan
                summa += siffraTal;
            }

        
        }
    }
}
