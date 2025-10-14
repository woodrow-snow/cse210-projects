public class SwimmingExercise : Exercise
{
    private int _numOfLaps;

    public SwimmingExercise(int laps, int len) : base(len, "Swimming")
    {
        _numOfLaps = laps;
    }

    public override double GetDistance()
    {
        return _numOfLaps * 50.0 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (double)GetDistance() / _lengthInMinutes * 60.0;
    }
}