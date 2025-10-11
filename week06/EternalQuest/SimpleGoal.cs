class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string descript, string points) : base(name, descript, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string descript, string points, bool complete) : base(name, descript, points)
    {
        _isComplete = complete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congradulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }

}