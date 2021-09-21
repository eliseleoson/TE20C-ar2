using System;

namespace Uppgift_2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            int dagar = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många kilometer ska du köra?");
            int kilometer = int.Parse(Console.ReadLine());

            int kostnad = 300 + 500 * (dagar - 1) + kilometer;
            Console.WriteLine($"Det kostar {kostnad} kr att hyra bilen.");
        }
    }
}
