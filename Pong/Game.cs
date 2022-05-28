using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace Pong
{
    public class Game
    {
        public bool WindowShouldClose => Raylib.WindowShouldClose();

        public Game(Vector2 size, int fps, string title)
        {
            Raylib.SetTargetFPS(60);
            Raylib.InitWindow((int) size.X, (int) size.Y, title);
        }

        public void Tick()
        {
            Update();
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.RAYWHITE);
            Draw();
            Raylib.EndDrawing();
        }

        private void Update()
        {

        }

        private void Draw()
        {
            
        }
    }
}
