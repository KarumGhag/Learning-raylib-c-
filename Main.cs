using Raylib_cs;
using System.Numerics;

using GlobalInfo;
using CircleEntityClass;
using System.Reflection.Metadata;

namespace MainRay;

public class Main
{

    List<CircleEntity> circleEntities = new List<CircleEntity>();


    public Main()
    {
        CircleEntity entity = new CircleEntity(Global.CENTER, 50, Color.Blue, circleEntities);
    }

    public void Start()
    {
        Raylib.InitWindow(Global.WIDTH, Global.HEIGHT, Global.NAME);

        while (!Raylib.WindowShouldClose())
        {

            Global.deltaTime = Raylib.GetFrameTime();

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.LightGray);

            foreach (CircleEntity circle in circleEntities) circle.Draw();

            if (Raylib.IsKeyDown(KeyboardKey.A)) circleEntities[0].position.X -= 500 * Global.deltaTime;
            if (Raylib.IsKeyDown(KeyboardKey.D)) circleEntities[0].position.X += 500 * Global.deltaTime;

            if (Raylib.IsKeyDown(KeyboardKey.W)) circleEntities[0].position.Y -= 500 * Global.deltaTime;
            if (Raylib.IsKeyDown(KeyboardKey.S)) circleEntities[0].position.Y += 500 * Global.deltaTime;



            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}