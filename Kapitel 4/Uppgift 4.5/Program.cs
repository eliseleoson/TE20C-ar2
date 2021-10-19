using System;

namespace Uppgift_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            for (int årtal = 1495; årtal >= 1400; årtal -= 5)
            {
                Console.WriteLine(årtal);
            }
        }
    }
}
