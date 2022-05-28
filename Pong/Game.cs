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
        private readonly Padel _leftPadel = new Padel(new Vector2(100, 100), KeyboardKey.KEY_W, KeyboardKey.KEY_S, Color.DARKGREEN); 
        private readonly Padel _rightPadel = new Padel(new Vector2(1480, 100), KeyboardKey.KEY_UP, KeyboardKey.KEY_DOWN, Color.RED); 

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
            _leftPadel.Update();
            _rightPadel.Update();
        }

        private void Draw()
        {
            _leftPadel.Draw();
            _rightPadel.Draw();
        }
    }
}
