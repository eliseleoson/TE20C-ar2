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
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);

            // Skapa en spelare av retangel
            Texture2D avatar = Raylib.LoadTexture(@"./avatar.png");
            Rectangle spelare = new Rectangle(100,100,50,50);
            Texture2D warning = Raylib.LoadTexture(@"./warnings.png");
            Rectangle fiende = new Rectangle(500,500,50,50);

            
            

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                /* Rita ut grafiken */
                // Börja rita
                Raylib.BeginDrawing();

                // Töm ritytan
                Raylib.ClearBackground(Color.DARKBLUE);

                // Rita ut spelaren
                Raylib.DrawTexture(avatar, (int)spelare.x, (int)spelare.y, Color.WHITE);
                Raylib.DrawTexture(warning, (int)fiende.x, (int)fiende.y, Color.WHITE);
                
                

                // Ritat ut på fönstret
                Raylib.EndDrawing();

                /* Interaktion med användaren */
                // Lyssna på tangentbordet
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    spelare.x +=5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    spelare.x -=5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    spelare.y +=5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    spelare.y -=5;
                }

                /* Fiende */
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    fiende.x +=5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    fiende.x -=5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    fiende.y +=5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    fiende.y -=5;
                }
            }
        }
    }
}

