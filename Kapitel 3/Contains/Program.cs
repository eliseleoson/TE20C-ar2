using System;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Mata in din e-mail: ");
            string email = Console.ReadLine();
            
            // Kolla att @ finns i texten 
            if (email.Contains("@"))
            {
                Console.WriteLine("Du har skrivit in en korrekt email adress");
            }

            Console.WriteLine("Mata in en simpel ekvation: ");
            string ekvation = Console.ReadLine();

            bool flagga = false;

            if (ekvation.Contains("+"))
            {
                Console.WriteLine("Du använder operator +");
                flagga = true;
            }
            if (ekvation.Contains("-"))
            {
                Console.WriteLine("Du använder operator -");
                flagga = true;
            }
            if (ekvation.Contains("*"))
            {
                Console.WriteLine("Du använder operator *");
                flagga = true;
            }
            if (ekvation.Contains("/"))
            {
                Console.WriteLine("Du använder operator /");
                flagga = true;
            }
            if (flagga == true)
            {
                Console.WriteLine("Du använder +,-,*,/");
            }
        }
    }
}
