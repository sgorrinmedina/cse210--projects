using System;

public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // Distance = (speed / 60) * minutes
        return (_speed / 60) * GetLengthInMinutes();
    }



    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        // Pace = 60 / speed
        return 60 / _speed;
    }
}
