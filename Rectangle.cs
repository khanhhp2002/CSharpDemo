namespace CSharpDemo;

public class Rectangle
{
    //Property
    public float Width { get;  set; }
    public float Height { get;  set; }

    //Constructor
    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    // Methods
    public void Draw()
    {
        for (int i = 0; i < this.Height; i++)
        {
            for (int j = 0; j < this.Width; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }

    public virtual double Area()
    {
        return this.Width * this.Height;
    }



    public override string ToString()
    {
        return "Rectangle: Width = " + Width + ", Height = " + Height;
    }
}
