using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int constructTop)
    {
        _top = constructTop;
        _bottom = 1;
    }

    public Fraction(int constructTop, int constructBottom)
    {
        _top = constructTop;
        _bottom = constructBottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

    public int getNumerator()
    {
        return _top;
    }

    public void setNumerator(int numerator)
    {
        _top = numerator;
    }

    public int getDenominator()
    {
        return _bottom;
    }

    public void setDenominator(int denominator)
    {
        _bottom = denominator;
    }
}





