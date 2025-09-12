using System;
using System.Net;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        // Exceeding Requirements
        // added functionality to add the .csv to the end of the filename to ensure that all files when saved or loaded are .csv
        // added ability to save and load from a .csv file 

        Console.WriteLine("Welcome to your Journal!");

        // creating journal object
        Journal userJourn = new Journal();

        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Display All");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);

            if (choice == 1)
            {
                // create
                createNewEntry();
            }
            else if (choice == 2)
            {
                // display all
                userJourn.DisplayAll();
            }
            else if (choice == 3)
            {
                // save
                userJourn.SaveToFile();
            }
            else if (choice == 4)
            {
                // Load
                userJourn.LoadFromFile();
            }
            else if (choice == 5)
            {
                // quit
                break;
            }
            else
            {
                Console.WriteLine($"{choice} is not an option, please try again...");
                // spacing line
                Console.WriteLine("");
            }

            Console.WriteLine("");
        }

        void createNewEntry()
        {
            // create new entry obj
            Entry entryToBeAdded = new Entry();

            // creating new PromptGenerator obj and getting prompt to ask user
            PromptGenerator pg = new PromptGenerator();
            string entryPrompt = pg.GetRandomPrompt();

            // display the prompt
            Console.WriteLine($"{entryPrompt}");

            // getting user input
            Console.Write("> ");
            string response = Console.ReadLine();

            // getting date
            DateTime currentDaate = DateTime.Now;
            string dateText = currentDaate.ToShortDateString();

            // assign entry varibles
            entryToBeAdded._prompt = entryPrompt;
            entryToBeAdded._input = response;
            entryToBeAdded._date = dateText;

            // add new entry to journal
            userJourn.AddEntry(entryToBeAdded);
        }
    }
}