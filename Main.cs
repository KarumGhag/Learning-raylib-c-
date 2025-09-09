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
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.LightGray);

            foreach (CircleEntity circle in circleEntities) circle.Draw();



            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}