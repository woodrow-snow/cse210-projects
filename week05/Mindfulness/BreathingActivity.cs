class BreathingActivity : Activity
{
    private int _timeBreathIn;
    private int _timeBreathOut;

    public BreathingActivity(string description) : base("Breathing", description)
    {
        _timeBreathIn = 4;
        _timeBreathOut = 6;
    }

    private void Breathing()
    {
        // breathing
        Console.Write($"Breath in... ");
        CountDown(_timeBreathIn);
        Console.WriteLine();
        Console.Write($"Breath out... ");
        CountDown(_timeBreathOut);
        Console.WriteLine();
        Console.WriteLine();
    }

    public void Run()
    {
        // Displaying starting message and description
        DisplayStartingMessage();

        // assigning method to delegate
        ActivityRoutine doBreathing = Breathing;

        // creating while loop for breathing
        CreateWhileLoop(doBreathing);

        DisplayEndingMessage();
    }
}