using System;

class Program
{
    static void Main(string[] args)
    {
        // getting first name
        Console.Write("What is your first name? ");
        string FName = Console.ReadLine();

        // getting last name
        Console.Write("What is your last name? ");
        string l_name = Console.ReadLine();

        // printing out name
        Console.WriteLine();
        Console.WriteLine($"Your name is {l_name}, {FName} {l_name}.");
    }
}