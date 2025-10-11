abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string descript, string points)
    {
        _shortName = name;
        _description = descript;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public virtual int GetPoints()
    {
        return int.Parse(_points);
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        // checking if goal is completed and acting appropiatly
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }

    public abstract string GetStringRepresentation();
    
}