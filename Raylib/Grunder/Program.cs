using System;
using Raylib_cs;

namespace Grunder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej Raylib!");

            // Starta ett fönster
            Raylib.InitWindow(800, 600, "Ett raylib fönster");

            // Fps
            Raylib.SetTargetFPS(60);

            // Egen färg
            Color GoldenRed = new Color(218,165,32,255);

            // Animationsloop
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Tömma rit ytan
                Raylib.ClearBackground(Color.GRAY);

                // Rita fyrkant
                Raylib.DrawRectangle(100,100,600,400, Color.WHITE);

                Raylib.DrawCircle(390,300, 120, Color.RED);
                
                // Text
                Raylib.DrawText("Japans Flag", 100,520, 50, Color.BLACK);

                // Sluta rita
                Raylib.EndDrawing();
            }


        }
    }
}
