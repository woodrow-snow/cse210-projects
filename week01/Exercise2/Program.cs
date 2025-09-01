using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // getting user input
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        string letter = "";

        // converting user input to int
        int gradeNum = int.Parse(userInput);

        // finding letter grade using if statement
        if (gradeNum >= 90)
        {
            letter = "A";
        }
        else if (gradeNum >= 80)
        {
            letter = "B";
        }
        else if (gradeNum >= 70)
        {
            letter = "C";
        }
        else if (gradeNum >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge 1, 2 and 3
        // Determining sign
        int lastDigit = gradeNum % 10;
        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            letter += "+";
        }
        else if (lastDigit < 3 && letter != "A" && letter != "F")
        {
            letter += "-";
        }
        

        // printing results
        Console.WriteLine($"Your letter grade is: {letter}");

        // separate if statement to check is passed class
        if (gradeNum >= 70)
        {
            Console.WriteLine("Congratulations! You Passed the Class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class, please try again!");
        }
    }
}