using System.Drawing;

class EternalGoal : Goal
{
    public EternalGoal(string name, string descript, string points) : base(name, descript, points) { }
    
    public override void RecordEvent()
    {
        Console.WriteLine($"Congradulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }

}