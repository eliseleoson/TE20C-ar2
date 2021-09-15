using System;

namespace Lucktext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Please write a place");
            string place = Console.ReadLine();

            Console.WriteLine("Please write a name");
            string person = Console.ReadLine();
            
            Console.WriteLine("Please write a plural adjective(adjektiv)");
            string adj1 = Console.ReadLine();
            
            Console.WriteLine("Please write a clothing item");
            string clothing = Console.ReadLine();

            Console.WriteLine("Please write a part of the body");
            string bodypart = Console.ReadLine();
            
            Console.WriteLine($"The year was 1803 in {place}, as {person} entered the disco they saw a {adj1} fireman DJ wearing a complementary {clothing} on their {bodypart} ");
            
        }
    }
}
