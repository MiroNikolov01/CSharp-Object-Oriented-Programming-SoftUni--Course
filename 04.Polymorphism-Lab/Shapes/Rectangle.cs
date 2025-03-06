using System.Security.Cryptography;

namespace Shapes;

public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.height = height;
        this.width = width;
    }
    public override double CalculatePerimeter()
    {
        // Perimeter of rectangle = 2 * (width + height)
        return 2 * (width + height);
    }

    public override double CalculateArea()
    {
        // Area of rectangle = width * height
        return width * height;
    }
    public override string Draw()
    {
        return base.Draw();
    }
}