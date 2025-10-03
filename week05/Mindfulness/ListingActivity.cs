using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _promptList = new List<string>();
    private int _totalItemsEntered;
    private Random _rand = new Random();

    public ListingActivity(string descript) : base("Listing", descript)
    {
        _promptList = ["Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        ];

        _totalItemsEntered = 0;
    }

    private string GetRandomPrompt()
    {
        return _promptList[_rand.Next(0,_promptList.Count - 1)];
    }

    private void Listing()
    {
        Console.Write("> ");
        Console.ReadLine();
        _totalItemsEntered++;
    }

    public void Run()
    {
        // Displaying Starting content
        DisplayStartingMessage();

        Console.WriteLine("List as many response you can to the following prompt");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write($"You may begin in: ");
        CountDown(5);
        Console.WriteLine(); //break line

        // assigning listing method to delegate
        ActivityRoutine doListing = Listing;

        // creating while loop
        CreateWhileLoop(doListing);

        Console.WriteLine($"You listed {_totalItemsEntered} items!");
        Console.WriteLine(); //break line
        DisplayEndingMessage();
    }
}