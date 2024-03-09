using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int selection = 0;
        Journal theJournal = new Journal();

        PromptGenerator promptList = new PromptGenerator();
        promptList._prompts.Add("What happened today? "); 
        promptList._prompts.Add("What was the best thing that happened today? "); 
        promptList._prompts.Add("What was the worst thing that happened today? "); 
        promptList._prompts.Add("What was the most interesting thing I saw or heard today? "); 
        promptList._prompts.Add("What was the most challenging thing I faced today? "); 
        promptList._prompts.Add("What am I grateful for today? "); 
        promptList._prompts.Add("What did I learn today? "); 
        promptList._prompts.Add("What was the most fun thing I did today? "); 
        promptList._prompts.Add("What was the most surprising thing that happened today? "); 
        promptList._prompts.Add("What did I do today that I am proud of? "); 

        Console.WriteLine("\nWelcome to the Journal Program!");
        while (selection != 6)
        {
        Console.WriteLine("\nPlease select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Delete Journal Entries");
        Console.WriteLine("6. Quit");
        Console.Write("What would you like to do? ");
        string userInput = Console.ReadLine();
        selection = int.Parse(userInput);

        if (selection == 1)
        {
            theJournal.EntryChecker("journalEntries.txt");
            DateTime theCurrentTime = DateTime.Now;
            Entry anEntry = new Entry();
            anEntry._date = theCurrentTime.ToShortDateString();
            string prompt = promptList.GetRandomPrompt();
            Console.WriteLine($"\n{prompt}");
            Console.Write(">");
            anEntry._entryText = Console.ReadLine();
            anEntry._promptText = prompt;
            theJournal.AddEntry(anEntry);
        }

        else if (selection == 2)
        {
            theJournal.DisplayAll();
        }

        else if (selection == 3)
        {
            string fileName = "journalEntries.txt";
            theJournal.LoadFromFile(fileName);
        }

        else if (selection == 4)
        {
            theJournal.SaveToFile(theJournal._entries);
        }

        else if (selection == 5)
        {
            theJournal._entries.Clear();
            theJournal.SaveToFile(theJournal._entries);
        }

        else if (selection == 6)
        {
            Console.WriteLine("Thank you for writing in your journal today.");
        }

        else
        {
            Console.WriteLine("Sorry, that is not a valid selection.");
        }

        }
    }
}