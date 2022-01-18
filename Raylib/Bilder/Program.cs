using System;
using Raylib_cs;

namespace Bilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Starta grafikmotorn
            Raylib.InitWindow(1000, 800, "Mitt Raylib fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);

            // Ladda in bilden
            Texture2D frog = Raylib.LoadTexture(@"./5845ec62dda95a5696fa1a27.png");
            Texture2D elmo = Raylib.LoadTexture(@"./uploads_elmo_elmo_PNG90515.png");

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Töm ritytan
                Raylib.ClearBackground(Color.DARKBLUE);

                // Rita ut bilder
                Raylib.DrawTexture(frog, 0, 0, Color.WHITE);
                Raylib.DrawTexture(elmo, 200, 200, Color.WHITE);

                // Ritat ut på fönstret
                Raylib.EndDrawing();
            }
        }
    }
}
