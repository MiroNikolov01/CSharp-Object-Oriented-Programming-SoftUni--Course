namespace _01.ClassBoxData;

public class Box
{
    public double Length { get; private set; }
    public double Width { get; private set; }
    public double Height { get; private set; }

    public Box(double length, double width, double height)
    {
        if (length <= 0) throw new ArgumentException($"Length cannot be zero or negative.");
        if (width <= 0) throw new ArgumentException($"Width cannot be zero or negative.");
        if (height <= 0) throw new ArgumentException($"Height cannot be zero or negative.");
        Length = length;
        Width = width;
        Height = height;
    }

    public double SurfaceArea() => 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
    public double Volume() => Length * Width * Height;
    public double LateralSurfaceArea() => 2 * Length * Height + 2 * Width * Height;
}