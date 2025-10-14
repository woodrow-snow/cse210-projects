public class RunningExercise : Exercise
{
    private int _distance;

    public RunningExercise(int distance, int len) : base(len, "Running")
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (double)_distance / _lengthInMinutes * 60.0;
    }
}