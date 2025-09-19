using System;
using System.Runtime.InteropServices;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        // program additions
        //      -made it so that when hiding words, x amount of new words are hidden and there are no repeats.
        //      -added private function to scripture class to get the total count of hidden words in the scripture
        // 

        // creating scripture object
        string words = "For it is expedient that I, the Lord, should make every man accountable, as a steward over earthly blessings, which I have made and prepared for my creatures.";
        Reference dc1204 = new Reference("D&C", 104, 13);
        Scripture verseToMemorize = new Scripture(dc1204, words);

        while (true)
        {
            // Clearing console
            Console.Clear();

            // printing out verse
            Console.WriteLine(verseToMemorize.GetDisplayText());

            // empty line
            Console.WriteLine("");

            // asking user for input
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            // cleaning up user input and comparing
            userInput = userInput.Trim();
            userInput = userInput.ToLower();

            if (userInput == "quit")
            {
                break;
            }
            else
            {
                verseToMemorize.HideRandomWords(3);
            }

            // checking to see if scripture is fully hidden
            if (verseToMemorize.IsCompletelyHidden())
            {
                break;
            }

            Console.ReadLine();
        }
    }
}