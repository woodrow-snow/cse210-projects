class Entry
{
    public string _prompt;
    public string _input;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_input);
    }
}