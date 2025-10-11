using System.Dynamic;
using System.Net.WebSockets;
using System.IO;
using System.IO.Enumeration;
using System.Runtime;

class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int _score;
    private int _level = 1;
    private int toLevelUp = 100;

    public GoalManager() { }

    public void Start()
    {
        while (true)
        {

            DisplayPlayerInfo();

            // displaying menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice form the menu: ");
            string userInput = Console.ReadLine();

            // checking user input and executing user command
            if (userInput == "1") // create
            {
                CreateGoal();
            }
            else if (userInput == "2") // list
            {
                ListGoalDetails();
            }
            else if (userInput == "3") // save
            {
                SaveGoals();
            }
            else if (userInput == "4") // load
            {
                LoadGoals();
            }
            else if (userInput == "5") // record
            {
                RecordEvent();
            }
            else if (userInput == "6") // quit
            {
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid input, please try again!");
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"You are level {_level}. -- {GetLevelName()} -- ");
        Console.WriteLine($"You need {CheckLevelUp()} more points to level up");
        Console.WriteLine();
    }

    private int CheckLevelUp()
    {
        int currentInLevel;

        // checking to see if score is lower than level up value
        if (_score < toLevelUp && _score != 0)
        {
            currentInLevel = toLevelUp % _score;
        }
        else
        {
            currentInLevel = _score % toLevelUp;
        }

        return toLevelUp - currentInLevel;
    }

    private string GetLevelName()
    {
        if (_level == 1)
        {
            return "Beginner";
        }
        else if(_level == 2)
        {
            return "Apprentice";
        }
        else if(_level == 3)
        {
            return "Dedicated Student";
        }
        else if(_level == 4)
        {
            return "Goal Completing Ninja";
        }
        else if(_level == 5)
        {
            return "Samuri of Goals";
        }
        else if(_level == 6)
        {
            return "Johnny 2-Goals";
        }
        else if(_level == 7)
        {
            return "The Wild Goal of the West";
        }
        else if(_level == 8)
        {
            return "Unicorn Ninja";
        }
        else if(_level == 9)
        {
            return "Ninja King";
        }
        else if(_level == 10)
        {
            return "Samuri Lord";
        }
        else
        {
            return "Samuri Lord, Ninja King, Fastest Gun in the West";
        }
    }

    private void ListGoalNames()
    {
        Console.WriteLine("The goals are: ");

        // var to count the amount of goals being displayed starting at one 
        int goalCount = 1;
        
        foreach (Goal g in goals)
        {
            Console.WriteLine($"{goalCount}. {g.GetName()}");
            goalCount++;
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("The Goals are: ");

        // var to count the amount of goals being displayed starting at one 
        int goalCount = 1;

        // getting goal information
        foreach (Goal g in goals)
        {
            // displaying goal
            Console.WriteLine($"{goalCount}. {g.GetDetailsString()}");

            // increasing goalCount by 1
            goalCount++;
        }
    }

    private string SetGoalPoints()
    {
        string points;
        Console.Write("Does the goal have a difficulty of easy, medium, or hard? ");
        string diff = Console.ReadLine();

        if (diff == "easy")
        {
            points = "5";
        }
        else if (diff == "medium")
        {
            points = "10";
        }
        else if (diff == "hard")
        {
            points = "15";
        }
        else
        {
            points = "10";
        }
        return points;
    }
    private void CreateGoal()
    {
        // getting goal type
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type of Goal would you like to create? ");
        string goalType = Console.ReadLine();

        // getting goal information based off of user input
        if (goalType == "1") // simple
        {
            // getting name
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            // getting description
            Console.Write("What is a short description of it? ");
            string descript = Console.ReadLine();

            // getting points
            string points = SetGoalPoints();

            SimpleGoal sGoal = new SimpleGoal(name, descript, points);
            goals.Add(sGoal);
        }
        else if (goalType == "2") // eternal
        {
            // getting name
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            // getting description
            Console.Write("What is a short description of it? ");
            string descript = Console.ReadLine();

            // getting points
            string points = SetGoalPoints();

            EternalGoal eGoal = new EternalGoal(name, descript, points);
            goals.Add(eGoal);
        }
        else if (goalType == "3")
        {
            // getting name
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            // getting description
            Console.Write("What is a short description of it? ");
            string descript = Console.ReadLine();

            // getting points
            string points = SetGoalPoints();

            // getting target
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            // getting bonus
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal cGoal = new ChecklistGoal(name, descript, points, target, bonus);
            goals.Add(cGoal);
        }
        Console.WriteLine("Goal Created!");
    }

    private void RecordEvent()
    {
        // I think we potenially need a getter for the amount of points
        // or make it so that the record event function return an int which is their points
        ListGoalNames();

        // getting goal to complete
        Console.Write("Which goal did you accomplish? ");
        int userInput = int.Parse(Console.ReadLine());
        userInput--; // getting user input to match array count 

        // getting goal from list and marking as complete
        goals[userInput].RecordEvent();

        // getting points and adding to score and telling user
        _score += goals[userInput].GetPoints();

        Console.WriteLine($"You now have {_score} points.");
    }

    private void SaveGoals()
    {
        // getting file name
        string filename = GetFilename();

        // opening the file with the using keyword
        using (StreamWriter output = new StreamWriter(filename))
        {
            // adding score to file first
            output.WriteLine(_score);

            // writing each goal in the list to the file
            foreach (Goal g in goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        // getting file name
        string filename = GetFilename();

        // creating varibles for common goal info types
        int nameIndex = 0;
        int descriptIndex = 1;
        int pointsIndex = 2;

        // opening file
        using (StreamReader input = new StreamReader(filename))
        {
            // getting points from file first
            _score = int.Parse(input.ReadLine());

            // assinging level as needed
            int currentLevel = 1;
            int currentTotal = _score;

            while (true)
            {
                currentTotal -= toLevelUp;
                if (currentTotal >= 0)
                {
                    currentLevel++;
                }
                else
                {
                    break;
                }
            }
            
            if (currentLevel > _level)
            {
                _level = currentLevel;
            }

            // creating loop to go through each line
            while (!input.EndOfStream)
            {
                // getting full line of information
                string goalInfo = input.ReadLine();

                // split at :
                string[] splitTypeFromInfo = goalInfo.Split(":");

                // getting information from array
                string type = splitTypeFromInfo[0];
                string[] info = splitTypeFromInfo[1].Split(",");

                // checking for goal type and creating as needed
                if (type == "SimpleGoal")
                {
                    SimpleGoal sGoal = new SimpleGoal(info[nameIndex], info[descriptIndex], info[pointsIndex],bool.Parse(info[3]));
                    goals.Add(sGoal);
                }
                else if (type == "EternalGoal")
                {
                    EternalGoal eGoal = new EternalGoal(info[nameIndex], info[descriptIndex], info[pointsIndex]);
                    goals.Add(eGoal);
                }
                else if (type == "ChecklistGoal")
                {
                    ChecklistGoal cGoal = new ChecklistGoal(info[nameIndex], info[descriptIndex], info[pointsIndex], int.Parse(info[4]), int.Parse(info[3]), int.Parse(info[5]));
                    goals.Add(cGoal);
                }
            }
        }
    }
    
     private string GetFilename()
    {
        // getting file name
        Console.Write("What is the filename for the goal file (don't worry about the file extension)? ");
        string filename = Console.ReadLine();

        filename += ".txt";

        return filename;
    }
}