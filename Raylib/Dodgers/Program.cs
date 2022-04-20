using System;
using Raylib_cs;

namespace Dodgers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisering
            //--------------------------------------------------------------------------------------
            const int fönsterB = 800;
            const int fönsterH = 600;

            Raylib.InitWindow(fönsterB, fönsterH, "Dogers");
            Raylib.SetTargetFPS(60);

            // TODO: Infoga variabler och objekt här
            // Gamestate varibler
            int poäng = 0;
            int liv = 3;
            float tid = 0;
            int hastighet = 1;

            Random generator = new Random();
            Rectangle mynt1 = new Rectangle(1000, 0, 50, 50);
            Rectangle mynt2 = new Rectangle(550, 0, 50, 50);
            Rectangle alien = new Rectangle(400, 0, 50, 50);
            Rectangle spelare = new Rectangle(100, fönsterH - 50, 100, 10);
            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                //----------------------------------------------------------------------------------
                // TODO: Uppdatera variabler här
                // Tid
                tid += Raylib.GetFrameTime();
                if (tid == 15)
                {
                    hastighet = 2;
                }
                // if (tid == 25)
                {
                    hastighet = 3;
                }

                // Kollision,tangenter, ny position
                mynt1.y += hastighet;
                if (mynt1.y > fönsterH)
                {
                    mynt1.y = -100;
                    mynt1.x = generator.Next(0, fönsterB);
                }
                mynt2.y += hastighet;
                if (mynt2.y > fönsterH)
                {
                    mynt2.y = -100;
                    mynt2.x = generator.Next(0, fönsterB);
                }
                alien.y += hastighet;
                if (alien.y > fönsterH)
                {
                    alien.y = -100;
                    alien.x = generator.Next(0, fönsterB);
                }

                // Lyssna på tangenter
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    if (spelare.x > 3)
                    {
                        spelare.x -= 3;
                    }
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    if (spelare.y < fönsterB - 100)
                    {
                        spelare.x += 3;
                    }
                }

                // Om spelare kolliderar med mynt
                if (Raylib.CheckCollisionRecs(spelare, mynt1))
                {
                    mynt1.y = 0;
                    mynt1.x = generator.Next(0, fönsterB);
                    poäng += 5;
                }
                if (Raylib.CheckCollisionRecs(spelare, mynt2))
                {
                    mynt2.y = 0;
                    mynt2.x = generator.Next(0, fönsterB);
                    poäng += 5;
                }
                if (Raylib.CheckCollisionRecs(spelare, alien))
                {
                    alien.y = 0;
                    alien.x = generator.Next(0, fönsterB);
                    liv -= 1;
                }
                //----------------------------------------------------------------------------------

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKGRAY);

                Raylib.DrawRectangleRec(mynt1, Color.GOLD);
                Raylib.DrawRectangleRec(mynt2, Color.GOLD);
                Raylib.DrawRectangleRec(alien, Color.RED);
                Raylib.DrawRectangleRec(spelare, Color.SKYBLUE);
                Raylib.DrawText($"Poäng: {poäng} Liv: {liv} Tid: {(int)tid}", 10, 10, 20, Color.BLACK);
                

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }
    }
}
