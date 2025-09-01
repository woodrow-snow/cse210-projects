using System;

class Program
{
    static void Main(string[] args)
    {
        // getting magic number
        Random randGen = new Random();
        int magicNum = randGen.Next(1, 21);

        int guess = 0;

        do
        {
            // getting guess from user
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            // using if statement to determine if user needs to guess higher or lower next
            if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNum);
        
    }
}