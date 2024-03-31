//When loading goals, a list of goal files or txt files will be displayed to choose from. This will help the user know what files are available to choose from.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}