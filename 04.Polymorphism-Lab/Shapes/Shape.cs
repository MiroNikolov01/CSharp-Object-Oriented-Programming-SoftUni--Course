﻿namespace Shapes;

public abstract class Shape
{
    public abstract double CalculatePerimeter();
    public abstract double CalculateArea();
    public virtual string Draw()
    {
        return $"Drawing {this.GetType().Name}";
    }
}