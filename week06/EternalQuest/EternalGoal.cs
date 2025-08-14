public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }

    public override bool IsComplete()
    {
        // An eternal goal is never complete
        return false;
    }

    public override string GetStringRepresentation()
    {
        // Format: EternalGoal:name,description,points
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}

