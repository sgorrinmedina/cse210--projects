using System;

public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public void SetLenght(double lenght)
    {
        _lenght = lenght;
    }

    public void SetWidth(double width)
    {
        _width = width
    }

    public double GetLenght()
    {
        return _lenght;
    }

    public double GetWidth()
    {
        return width;
    }

    public override double GetArea()
    {
        return _lenght * _width;
    }
}