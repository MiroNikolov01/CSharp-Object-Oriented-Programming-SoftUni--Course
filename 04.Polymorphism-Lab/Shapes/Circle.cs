namespace Shapes;

public class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double CalculatePerimeter()
    {
        // Perimeter of circle = 2 * π * r
        return 2 * Math.PI * radius;
    }

    public override double CalculateArea()
    {
        // Area of circle = π * r²
        return Math.PI * Math.Pow(radius, 2);
    }
    public override string Draw()
    {
        return base.Draw();
    }
}