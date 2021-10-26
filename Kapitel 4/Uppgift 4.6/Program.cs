using System;

namespace Uppgift_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string meddelande = "I said whoever threw that paper your moms a hoe";

            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}
