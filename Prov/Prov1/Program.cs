using System;

namespace Prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Rensar terminalen

            // Berättar vad programmet gör
            Console.WriteLine("Utträkning av nettolön");
            Console.WriteLine("--------------------------");

            // Frågar användaren om sitt namn
            Console.Write("Vad heter du? ");
            string Namn = Console.ReadLine();

            // Frågar användaren om sin bruttolön
            Console.Write("Ange din bruttolön i kr : ");
            int bruttolön = int.Parse(Console.ReadLine());

            while (true)
            {
                // Säger att bruttolönen inte får vara < 10000 kr
                if (bruttolön < 10000)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine($"{Namn}, din bruttolön måste vara > 10000 kr!");
                    Console.WriteLine("Försök igen");
                    break;
                }

                // Bruttolönen får inte vara > 45000 kr
                if (bruttolön > 45000)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine($"{Namn}, din bruttolön måste vara < 45000 kr!");
                    Console.WriteLine("Försök igen");
                    break;
                } 
                else
                {
                    // Frågar användaren om sin skattesats
                    Console.Write("Ange din skattesats i % : ");
                    int skattesats = int.Parse(Console.ReadLine());

                    // Skattesats får inte vara < 10%
                    if (skattesats < 10)
                    {
                        Console.WriteLine("--------------------------");
                        Console.WriteLine($"{Namn}, din skattesats måste vara > 10%!");
                        Console.WriteLine("Försök igen");
                        break;
                    }

                    // Skattesats får inte vara > 45%
                    if (skattesats > 45)
                    {
                        Console.WriteLine("--------------------------");
                        Console.WriteLine($"{Namn}, din skattesats måste vara < 45%!");
                        Console.WriteLine("Försök igen");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("--------------------------");
                        Console.WriteLine($"{Namn}, din nettolön blir {bruttolön * (100-skattesats)/ 100 } kr." );
                        Console.WriteLine($"Baserat på bruttolön {bruttolön} kr och skattesats {skattesats} %.");
                        break;

                    }
                }                   
                
            }
            

        }
    }
}
