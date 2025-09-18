using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction test3 = new Fraction(1, 1);

        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());

        test3.SetNumerator(5);

        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());

        test3.SetNumerator(3);
        test3.SetDemoninator(4);

        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());

        test3.SetNumerator(1);
        test3.SetDemoninator(3);
        
        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());
    }
}