using System.Numerics;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string descript, string points, int target, int bonus) : base(name, descript, points)
    {
        _target = target;
        _bonus = bonus;
    }

     public ChecklistGoal(string name, string descript, string points, int target, int bonus, int completed) : base(name, descript, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = completed;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            Console.WriteLine($"Congradulations! You have earned {_points} points!");
            _amountCompleted++;
        }
        else
        {
            Console.WriteLine($"{_shortName} has already been completed!");
        }
    }

    public override int GetPoints()
    {
        if (IsComplete())
        {
            Console.WriteLine($"Congradulations! You have earned {int.Parse(_points) + _bonus} points!");
            return int.Parse(_points) + _bonus;
        }
        else
        {
            Console.WriteLine($"Congradulations! You have earned {_points} points!");
            return int.Parse(_points);
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted < _target)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description}) -- Currently {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently {_amountCompleted}/{_target}";
        }
    }
    
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}