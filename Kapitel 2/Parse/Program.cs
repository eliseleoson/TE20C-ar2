using System;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur gammal är du? ");
            string ålder = Console.ReadLine();

            Console.WriteLine($"Du är {ålder} år gammal");

            //Konverterar från string till heltal
            int ålderTal = int.Parse(ålder);

            Console.WriteLine($"Du har {20 - ålderTal} år kvar tills du får gå på systemet");
            
            Console.Write("Hur mycket väger du? ");
            float vikt = float.Parse(Console.ReadLine());

            Console.WriteLine($"Din vikt blir {vikt * 2.2} lbs");

            float viktlbs = vikt * 2.2f;

            //Formatera till en snygg utskrift
            string viktString = viktlbs.ToString("0.##");
            Console.WriteLine($"Din vikt är {viktString} lbs");
        }
    }
}
