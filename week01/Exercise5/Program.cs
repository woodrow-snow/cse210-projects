using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int favSquared = SquareNumber(favNum);
        DisplayResult(favSquared, name);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int favNum = int.Parse(userInput);
        return favNum;
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(int num, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {num}");
    }
}