using System;

public abstract class Shape
{
    private string _color;

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea()
}