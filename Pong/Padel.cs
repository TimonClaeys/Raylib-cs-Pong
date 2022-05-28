using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace Pong
{
    public class Padel
    {
        private Rectangle _rectangle;
        private readonly Color _color;
        private readonly KeyboardKey _upKey;
        private readonly KeyboardKey _downKey;

        public Vector2 Position
        {
            get => new Vector2(_rectangle.x, _rectangle.y);
            set => _rectangle = new Rectangle(value.X, value.Y, _rectangle.width, _rectangle.height);
        }

        public Padel(Vector2 pos, KeyboardKey upKey, KeyboardKey downKey, Color color)
        {
            _upKey = upKey;
            _downKey = downKey;
            _color = color;
            _rectangle = new Rectangle(pos.X, pos.Y, 20, 100);
        }

        public void Update()
        {
            if (Raylib.IsKeyDown(_upKey))
            {
                Position = new Vector2(Position.X, Position.Y - 5);
            }
            if (Raylib.IsKeyDown(_downKey))
            {
                Position = new Vector2(Position.X, Position.Y + 5);
            }
        }

        public void Draw()
        {
            Raylib.DrawRectangleRec(_rectangle, _color);
        }
    }
}
