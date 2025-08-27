using System;

public class Circle : Shape
{
    private double _radius;

    public SetRadius(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }

}