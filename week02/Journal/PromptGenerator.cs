class PromptGenerator
{
    List<string> _prompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was one thing you did to server another person today?",
        "What is one event that happened that made you the happiest",
        "Who are you the most thankful for today?",
        "What is the worst thing that happened to you? How did it make you feel?",
        "What is one way you overcame adveristy today?",
        };

    public string GetRandomPrompt()
    {
        // getting index number for prompt
        Random rand = new Random();
        int promptIndex = rand.Next(0, _prompts.Count());

        // returning prompt at specified index
        return _prompts[promptIndex];
    }
}