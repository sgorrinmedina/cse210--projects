public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        int pointsEarned = GetPoints();
        if (_amountCompleted == _target)
        {
            pointsEarned += _bonus;
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points and a bonus of {_bonus}!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        // Format: ChecklistGoal:name,description,points,bonus,target,amountCompleted
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
    
    // This method is needed for loading the state correctly
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
}

