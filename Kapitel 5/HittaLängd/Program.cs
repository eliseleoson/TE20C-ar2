using System;

namespace HittaLängd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string [] AllaNamn = new string[3];

            // Fylla arrayen med Namn
            for (int i = 0; i < AllaNamn.Length; i++)
            {
                Console.Write("Ange ett namn: ");
                string Namn = Console.ReadLine();
                AllaNamn[i] = Namn; 
            }

            // Skriv ut alla namn + längden
            foreach (var Namn in AllaNamn)
            {
                Console.WriteLine($"{Namn} är {Namn.Length} tecken långt");
            }


        }
    }
}
