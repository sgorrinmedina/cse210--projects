using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    // Abstract methods that must be overridden by derived classes
    public abstract double GetDistance(); // in miles
    public abstract double GetSpeed();    // in mph
    public abstract double GetPace();     // in min per mile

    // A virtual method that provides a default implementation
    public virtual string GetSummary()
    {
        // Format: 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        string activityType = GetType().Name; // Gets the name of the derived class (e.g., "Running")
        return $"{_date.ToString("dd MMM yyyy")} {activityType} ({_lengthInMinutes} min) - " +
               $"Distance: {GetDistance():F2} miles, " +
               $"Speed: {GetSpeed():F2} mph, " +
               $"Pace: {GetPace():F2} min per mile";
    }
    
    // Protected getter for derived classes to use
    protected int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }
}
