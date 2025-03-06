namespace Shapes;

public class StartUp
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(10);
        Console.WriteLine(circle.Draw());
        Console.WriteLine(circle.CalculatePerimeter());
        Shape rectangle = new Rectangle(10, 20);
        Console.WriteLine(rectangle.Draw());
        Console.WriteLine(rectangle.CalculatePerimeter());
        Console.WriteLine(rectangle.CalculateArea());
    }
}