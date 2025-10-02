using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assi1 = new Assignment("Woodrow", "Programming");
        Console.WriteLine(assi1.GetSummary());

        MathAssignment assi2 = new MathAssignment("Roe", "Nursing", "Section 9.3", "Problems 3-19");
        Console.WriteLine(assi2.GetHomeworkList());

        WritingAssignment assi3 = new WritingAssignment("Keira", "Food Health", "The Effect of Sugar on the Body");
        Console.WriteLine(assi3.GetWritingInformation());
    }
}