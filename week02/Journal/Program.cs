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
        // added ability for user to use one of the following statements to enter command
        //      - number ex: 1
        //      - command name ex: create
        //      - full line ex: 1. create

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

            // getting user input
            string userInput = Console.ReadLine();
            int choice = -1;
            string nChoice = "";
            bool isString = false;

            try
            {
                choice = int.Parse(userInput);
            }
            catch (Exception)
            {
                nChoice = userInput.Trim();
                isString = true;
            }
            finally
            {
                nChoice.ToLower();
            }


            if (choice == 1 || nChoice == "create" || nChoice == "1. create")
            {
                // create
                createNewEntry();
            }
            else if (choice == 2 || nChoice == "display all" || nChoice == "2. display all")
            {
                // display all
                userJourn.DisplayAll();
            }
            else if (choice == 3 || nChoice == "save" || nChoice == "3. save")
            {
                // save
                userJourn.SaveToFile();
            }
            else if (choice == 4 || nChoice == "load" || nChoice == "4. load")
            {
                // Load
                userJourn.LoadFromFile();
            }
            else if (choice == 5 || nChoice == "quit" || nChoice == "5. quit")
            {
                // quit
                break;
            }
            else
            {
                if (isString)
                {
                    Console.WriteLine($"{nChoice} is not an option, please try again...");
  
                }
                else
                {
                    Console.WriteLine($"{choice} is not an option, please try again...");
                }
                
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