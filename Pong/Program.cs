using System.Numerics;
using Pong;

Game game = new Game(new Vector2(1600, 900), 60, "PONG");

while (!game.WindowShouldClose)
{
    game.Tick();
}