using System;

class Program
{
    static void Main(string[] args)
    {
        // creating and displaying job 1
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._endYear = 2012;
        job1._startYear = 2008;
        job1.Display();

        // creating and displaying job 2
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Senior Software Engineer";
        job2._endYear = 2025;
        job2._startYear = 2012;
        job2.Display();

        // breaking line
        Console.WriteLine();

        // creating and new resume obj and adding jobs
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // displaying jobs again
        myResume.Display();
        
    }
}