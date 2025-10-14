public abstract class Exercise
{
    protected string _date;
    protected int _lengthInMinutes;
    private string _exerciseType;

    public Exercise(int len, string type)
    {
        _date = DateTime.Now.ToShortDateString();
        _lengthInMinutes = len;
        _exerciseType = type;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public double GetPace()
    {
        return 60 / GetSpeed();
    }

    public virtual string GetSummary()
    {
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        // ^^^ how return string should look ^^^

        return $"{_date} {_exerciseType} ({_lengthInMinutes} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}