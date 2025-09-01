using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int numToAdd = -1;
        List<int> nums = new List<int>();

        while (numToAdd != 0)
        {
            Console.Write("Enter Number: ");
            string userInput = Console.ReadLine();
            numToAdd = int.Parse(userInput);

            if (numToAdd != 0)
            {
                nums.Add(numToAdd);
            }
        }

        // getting sum
        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // getting average
        float average = ((float)sum) / nums.Count;
        Console.WriteLine($"The average is: {average}");

        // getting largest number
        int highest = -99999;
        foreach (int num in nums)
        {
            if (num > highest)
            {
                highest = num;
            }
        }
        Console.WriteLine($"The largest number is: {highest}");


    }
}