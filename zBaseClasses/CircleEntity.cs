using Raylib_cs;
using System.Numerics;

using GlobalInfo;

namespace CircleEntityClass;

public class CircleEntity
{
    public Vector2 position;
    Color colour;
    int radius;

    public CircleEntity(Vector2 position, int radius, Color colour, List<CircleEntity> circleEntities)
    {
        this.position = position;
        this.radius = radius;

        this.colour = colour;

        circleEntities.Add(this);
    }

    public void Draw()
    {
        Raylib.DrawCircleV(position, radius, colour);
    }

}