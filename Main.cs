using Raylib_cs;
using GlobalInfo;

namespace MainRay;

public class Main
{
    public void Start()
    {
        Raylib.InitWindow(Global.WIDTH, Global.HEIGHT, Global.NAME);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.LightGray);

            Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Black);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}