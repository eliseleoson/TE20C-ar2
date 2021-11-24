using System;

namespace Lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Välkommen till Lyckohjulet!");
            
            // Slumpa fram ett tal
            Random slumpgenerator = new Random();
            int slumptal = slumpgenerator.Next(1,11);
            
            // Frågar användaren om ett tal
            Console.Write("Ange ett tal mellan 1-10 som du tror hjulet kommer stanna på, du har 3 försök: "); 
            
            // Räknar antal försök
            int räknare = 0;
            
            while (true)
            {
                 räknare++;
                
                // Inte fler än 3 gissningar
                if (räknare >= 4)
                {
                    break;
                }

                Console.Write("");
                int gissning = int.Parse(Console.ReadLine());

                // Om man gissar rätt
                if (slumptal == gissning)
                {
                    Console.WriteLine($"Du gissade rätt! Svaret var {slumptal}");
                    break;
                }
                
                // Om man tar alla tre försök
                if (räknare == 3)
                {
                    Console.WriteLine($"Du förlorade :( Svaret var {slumptal}"); 
                }
                else 
                {
                    Console.WriteLine("Testa igen");
                }
            
            }
                

                
           
            
            

        }
    }
}
