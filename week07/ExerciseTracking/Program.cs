using System;

class Program
{
    static void Main(string[] args)
    {
        // creating list for all exercies
        List<Exercise> exercises = new List<Exercise>();

        // crearing Running exercise and adding to list
        RunningExercise running = new RunningExercise(3, 30);
        exercises.Add(running);

        // creating Cycling exercise and adding to list
        CyclingExercise cycling = new CyclingExercise(25, 10);
        exercises.Add(cycling);

        // creating and adding Swimming exercise
        SwimmingExercise swimming = new SwimmingExercise(40, 30);
        exercises.Add(swimming);

        foreach (Exercise e in exercises)
        {
            Console.WriteLine(e.GetSummary());
        }
    }
}