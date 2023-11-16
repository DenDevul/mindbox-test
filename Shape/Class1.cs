namespace Shape;
abstract class Shape
{
    public abstract float GetArea();
}

class Triangle : Shape
{
    public float SideA { get; private set; }
    public float SideB { get; private set; }
    public float SideC { get; private set; }

    public Triangle(float sideA, float sideB, float sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override float GetArea()
    {
        float s = (SideA + SideB + SideC) / 2;
        return MathF.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRightTriangle()
    {
        return MathF.Pow(SideA, 2) + MathF.Pow(SideB, 2) == MathF.Pow(SideC, 2) ||
               MathF.Pow(SideA, 2) + MathF.Pow(SideC, 2) == MathF.Pow(SideB, 2) ||
               MathF.Pow(SideB, 2) + MathF.Pow(SideC, 2) == MathF.Pow(SideA, 2);
    }
}

class Circle : Shape
{
    public float Radius { get; private set; }

    public Circle(float radius)
    {
        Radius = radius;
    }

    public override float GetArea()
    {
        return MathF.PI * MathF.Pow(Radius, 2);
    }
}
