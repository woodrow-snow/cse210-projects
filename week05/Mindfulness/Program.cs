using System;

class Program
{
    static void Main(string[] args)
    {

        // improvments made
        //      - created method in activty class to contain while loop that each run function is using. To use the method, a function must be passed in.
        //      - Updated how time reporting works at the end of any activity. Before it would only report what user entered, It will now reflect the actual time passed. Sometimes activity goes longer than users requested time.

        Console.Clear();

        // program loop
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();

            Console.Clear();

            // menu if statement
            userInput = userInput.Trim();
            if (userInput == "1")
            {
                string breathingDescript = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity breathing = new BreathingActivity(breathingDescript);
                breathing.Run();
            }
            else if (userInput == "2")
            {
                string reflectionDescript = "his activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectionActivity reflect = new ReflectionActivity(reflectionDescript);
                reflect.Run();
            }
            else if (userInput == "3")
            {
                string listingDescript = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity listing = new ListingActivity(listingDescript);
                listing.Run();
            }
            else if (userInput == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine($"That is not a valid input, please try again!");
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
    }
}