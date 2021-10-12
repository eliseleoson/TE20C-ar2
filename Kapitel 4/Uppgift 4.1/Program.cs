using System;

namespace Uppgift_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Frågar vilket land som har störst befolkning
            Console.WriteLine("Vilket land har störst befolkning");
            string svar = Console.ReadLine();
            
            //Om svaret inte är Kina fortsätter den fråga tills man svarar rätt
            while (svar != "Kina")
            {
                Console.WriteLine("Du svarade fel, försök igen");
                svar = Console.ReadLine();
            }

            Console.WriteLine("Grattis! Du svarade rätt!");
        }
    }
}
