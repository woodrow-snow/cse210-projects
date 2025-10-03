using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
class ReflectionActivity : Activity
{
    private List<string> _promptList = new List<string>();
    private List<string> _questionList = new List<string>();
    private Random _rand = new Random();

    public ReflectionActivity(string descript) : base("Reflection", descript)
    {
        _promptList = ["Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];

        _questionList = ["Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
    }

    private string GetRandomItem(List<string> items)
    {
        return items[_rand.Next(0, items.Count - 1)];
    }

    private void Reflection()
    {
        Console.Write($"> {GetRandomItem(_questionList)} ");
        Pause();
    }

    public void Run()
    {
        // displaying Starting message
        DisplayStartingMessage();

        Console.WriteLine("Consider the following Prompt:");
        Console.WriteLine(); // break line
        Console.WriteLine($" --- {GetRandomItem(_promptList)} --- ");
        Console.WriteLine(); // break line
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        CountDown(5);
        Console.Clear();

        // Assinging Reflection method to delegate
        ActivityRoutine doReflection = Reflection;

        // creating while loop
        CreateWhileLoop(doReflection);

        Console.WriteLine(); // break line
        DisplayEndingMessage();
    }
}