namespace CSharpDemo;

public class Circle : Rectangle
{
    public float radius { get; set; }

    public Circle(float radius, int width, int height) : base(width, height)
    {
        this.radius = radius;
    }

    public Circle(float radius) : base(0, 0)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return radius * radius * 3.14;
    }
}

