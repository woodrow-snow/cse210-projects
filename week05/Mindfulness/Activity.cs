using System.Runtime.InteropServices;

class Activity
{
    private string _activityType;
    private string _description;
    private int _timeInSeconds;
    private DateTime _timeDifference;

    protected delegate void ActivityRoutine();

    protected Activity(string type, string description)
    {
        _activityType = type;
        _description = description;
    }

    private void SetActivityDuration()
    {
        Console.Write($"How long, in seconds, would you like your session? ");
        string input = Console.ReadLine();
        _timeInSeconds = int.Parse(input);
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityType} Activity");
        Console.WriteLine(); // break line
        Console.WriteLine(_description);
        Console.WriteLine(); // break line

        // setting activity duration
        SetActivityDuration();

        // clearing console
        Console.Clear();

        // asking client to get ready
        Console.WriteLine("Get ready...");
        Pause();

        _timeDifference = DateTime.Now;
    }

    protected void DisplayEndingMessage()
    {
        // getting final ending time and calcuating how much time user spent on activity
        DateTime endingTime = DateTime.Now;
        TimeSpan result = endingTime - _timeDifference;

        Console.WriteLine("Well done!!");
        Pause();
        Console.WriteLine($"You have completed {(int)result.TotalSeconds} seconds of the {_activityType} Activity.");
        Pause();
        Console.Clear();
    }

    protected void Pause()
    {
        // creating animation strings - ^>V<
        List<string> animationStrings = new List<string>() { "^", ">", "v", "<" };

        int i = 0;
        int secondsToAdd = 5;

        // getting current and future date
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(secondsToAdd);

        // playing animation
        while (DateTime.Now < endTime)
        {
            string current = animationStrings[i];
            Console.Write(current);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

        // break line
        Console.WriteLine("");
    }

    protected void CountDown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected void CreateWhileLoop(ActivityRoutine loopBlock)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timeInSeconds); // update method in add seconds

        while (DateTime.Now < endTime)
        {
            loopBlock();
        }
    }
}