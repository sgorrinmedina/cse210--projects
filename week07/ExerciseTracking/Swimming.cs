using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Distance (miles) = swimming laps * 50 / 1000 * 0.62
        return _laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        // Speed (mph) = (distance / minutes) * 60
        return (GetDistance() / GetLengthInMinutes()) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = minutes / distance
        return GetLengthInMinutes() / GetDistance();
    }
}
