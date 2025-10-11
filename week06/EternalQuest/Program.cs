using System;

class Program
{
    static void Main(string[] args)
    {
        // Program Creative Additions
        //      [X] in GoalManager, instead of asking for goal amount, asks for difficultly of goal instead and assigns point value
        //      [X] made it so user does not need to include the .filetype tag in their filename
        //      [X] add leveling system with fun names, ends at level 10

        GoalManager gMan = new GoalManager();
        gMan.Start();
    }
}