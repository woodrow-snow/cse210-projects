public class CyclingExercise : Exercise
{
    private int _speed;

    public CyclingExercise(int speed, int len) : base(len, "Cycling")
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * _lengthInMinutes / 60.0;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

}