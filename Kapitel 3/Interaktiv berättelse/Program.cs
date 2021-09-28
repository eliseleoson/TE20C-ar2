using System;

namespace Interaktiv_berättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ooof! Du har hamnat i mörktunnel\nVad gör du? Gå fram eller bak?");
            string answer1 = Console.ReadLine().ToLower();

            if (answer1 == "fram")
            {
                Console.WriteLine("Du kommer fram till två dörrar, en svart och en grön. Vilken väljer du att ta? (Skriv färgen) ");
                string answer2 = Console.ReadLine().ToLower();
                if (answer2 == "svart")
                {
                    Console.WriteLine("Gudarna har dömt dig till en syndare och dödar dig!");
                }
                else
                {
                    Console.WriteLine("Du kommer fram till ett paradis med allt man kan tänka sig!");
                }
            }
            else
            {
                Console.WriteLine("Du börjar se ett ljus i tunneln och kommer fram till en korsning. Du kan välja att gå höger eller vänster ");
                string answer3 = Console.ReadLine().ToLower();
                if (answer3 == "höger")
                {
                    Console.WriteLine("Right, lmao du kommer ut ur tunneln.\nDu tror att du är säker \nMEN FEL! En stor örn kommer och äter upp dig! ");
                }
                else
                {
                    Console.WriteLine("Du kommer ut ur tunneln och blir plötsligt påkörd av en buss! \nDu stämmer bussbolaget och chaffören och blir biljonär av rättegången!");
                }
            }
        }
    }
}
