using System;
using Raylib_cs;
using System.Collections.Generic;

namespace ArkaneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //GAME VALUES
            int vH = 600;
            int vW = 800;
            Raylib.InitWindow(vW, vH, "Arkane");

            //PLAYER VALUES
            float playerX = 350;
            float playerY = 520;

            //BOX VALUES
            List<Rectangle> recList = new List<Rectangle>();

            Raylib.SetTargetFPS(144);

            while (!Raylib.WindowShouldClose())
            {
                Rectangle playerRec = new Rectangle(playerX, playerY, 100, 20);
                playerX = PlayerMovement(playerX);

                InitRaylib();
                Raylib.DrawRectangleRec(playerRec, Color.BLACK);

            }
        }

        static void InitRaylib()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            Raylib.EndDrawing();
        }

        static float PlayerMovement(float pX)
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && pX > 0)
            {
                pX -= 2;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && pX < 700)
            {
                pX += 2;
            }
            return pX;
        }
    }
}
