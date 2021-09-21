using System;

namespace Uppgift_2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange månadslön för tre av dina anställda på var sin rad");
            //Lön för person 1
            int lön1 = int.Parse(Console.ReadLine());
            //Lön för person 2
            int lön2 = int.Parse(Console.ReadLine());
            //Lön för person 3 
            int lön3 = int.Parse(Console.ReadLine()); 
            
            //Räkna ut medellönen hos alla personer
            float medellön = (lön1 + lön2 + lön3) / 3;
            //Float kan inte hantera decimaler men double kan
            Console.WriteLine($"Medellönen för dina anställda är {medellön} kr i månaden.");
        }
    }
}
