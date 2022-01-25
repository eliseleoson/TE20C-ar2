using System;
using Raylib_cs;

namespace Scener
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fönster
            const int fönsterB = 800;
            const int fönsterH = 600;

            Raylib.InitWindow(fönsterB, fönsterH, "raylib [cs]");
            Raylib.SetTargetFPS(60);

            float sek60 = 60;
            float sek45 = 45;
            string scen0 = "Scen 0";
            string scen1 = "Scen 1";
            string slut = "Gameover";

            Random generator = new Random();

            // Game state variabler
            int poäng = 0;

            // Karaktärer
            // Skapa en spelare av retangel
            Texture2D spelarebild = Raylib.LoadTexture(@"./sun.png");
            Texture2D fiendebild = Raylib.LoadTexture(@"./asteroids.png");
            Rectangle spelare = new Rectangle(generator.Next(1, 300), generator.Next(1, 550), spelarebild.width, spelarebild.height);
            Rectangle fiende = new Rectangle(generator.Next(300, 750), generator.Next(1, 550), fiendebild.width, fiendebild.height);


            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);

                if (scen0 == "Scen 0")
                {
                    // Rita ut objekt
                    Raylib.DrawText(scen0, 10, 10, 50, Color.RED);
                    Raylib.DrawText($"Poäng:{poäng}", 10,50,50, Color.RED);

                    // Rita ut spelarna
                    Raylib.DrawTexture(spelarebild, (int)spelare.x, (int)spelare.y, Color.WHITE);
                    Raylib.DrawTexture(fiendebild, (int)fiende.x, (int)fiende.y, Color.WHITE);

                    // Kollision
                    if (Raylib.CheckCollisionRecs(spelare, fiende))
                    {
                        // Slumpa fram en ny position
                        fiende.x = generator.Next(300, 750);
                        fiende.y = generator.Next(1, 550);
                        poäng++;
                    }

                    // Rita ut tiden
                    Raylib.DrawText($"Tid {(int)sek60}", 600, 0, 50, Color.RED);

                    // Räkna ned tiden kvar
                    sek60 -= Raylib.GetFrameTime();
                    if (sek60 <= 0)
                    {
                        scen0 = "Scen 1";
                    }
                }
                else if (scen1 == "Scen 1")
                {
                    // Rita ut objekt
                    Raylib.DrawText(scen1, 10, 10, 50, Color.RAYWHITE);
                    Raylib.DrawText($"Poäng:{poäng}", 10,50,50, Color.RAYWHITE);
                    Raylib.ClearBackground(Color.BLUE);

                    // Kollision
                    if (Raylib.CheckCollisionRecs(spelare, fiende))
                    {
                        // Slumpa fram en ny position
                        fiende.x = generator.Next(300, 750);
                        fiende.y = generator.Next(1, 550);
                        poäng++;
                    }

                    // Rita ut spelaren
                    Raylib.DrawTexture(spelarebild, (int)spelare.x, (int)spelare.y, Color.WHITE);
                    Raylib.DrawTexture(fiendebild, (int)fiende.x, (int)fiende.y, Color.WHITE);

                    // Rita ut tiden
                    Raylib.DrawText($"Tid {(int)sek45}", 600, 0, 50, Color.RED);

                    // Räkna ned tiden kvar
                    sek45 -= Raylib.GetFrameTime();
                    if (sek45 <= 0)
                    {
                        scen1 = "Slut";
                    }
                }
                else if (slut == "Gameover")
                {
                    Raylib.DrawText($"Du fick {poäng} poäng", 200, 200, 50, Color.RED);
                }

                Raylib.EndDrawing();

                /* Interaktion med användaren */
                // Lyssna på tangentbordet
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    spelare.x += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    spelare.x -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    spelare.y += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    spelare.y -= 5;
                }

                /* Fiende */
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    fiende.x += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    fiende.x -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    fiende.y += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    fiende.y -= 5;
                }
            }


        }
    }
}
