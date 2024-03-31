using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Reflection;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private string[] _txtFiles;

    public GoalManager()
    {
        //Initializes and empty list of goals and sets the player's score to be 0.
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int userSelection = 0;
        while (userSelection != 6)
        {
            DisplayPlayerInfo();

            Console.WriteLine("\nMenu Option:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            userSelection = int.Parse(userInput);

            if (userSelection == 1)
            {
                CreateGoal();
            }

            else if (userSelection == 2)
            {
                ListGoalDetails();
            }            

            else if (userSelection == 3)
            {
                SaveGoals();
            }

            else if (userSelection == 4)
            {
                LoadGoals();
            }

            else if (userSelection == 5)
            {
                RecordEvent();
            }

            else if (userSelection == 6)
            {
                Console.Write("\nThank you for using the Eternal Quest Program!\n");
            }

            else
            {
                Console.WriteLine("\nInvalid selection, please select option 1 - 6 to continue.");
            }

        }
    }

    void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    void ListGoalNames()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetShortName()} ");
        }
    }
       
    void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals are available, please add a goal.");
        }
        
        else
        {
            Console.WriteLine("\nThe goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                string completionStatus = _goals[i].IsComplete() ? "[X]" : "[ ]";
                Console.WriteLine($"{i + 1}. {completionStatus} {_goals[i].GetDetailsString()}");
            }
        }
    }

    public int GetScore()
    {
        return _score;
    }

    void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userInput = Console.ReadLine();
        int goalSelection = int.Parse(userInput);

        if (goalSelection == 1)
        {
            Console.Write("What is the name of you goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string userInput1 = Console.ReadLine();
            int goalPoints = int.Parse(userInput1);
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(simpleGoal);
        }

        else if (goalSelection == 2)
        {
            Console.Write("What is the name of you goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string userInput1 = Console.ReadLine();
            int goalPoints = int.Parse(userInput1);
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(eternalGoal);
        }

        else if (goalSelection == 3)
        {
            Console.Write("What is the name of you goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string userInput1 = Console.ReadLine();
            int goalPoints = int.Parse(userInput1);
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string userInput2 = Console.ReadLine();
            int goalTarget = int.Parse(userInput2);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string userInput3 = Console.ReadLine();
            int goalBonus = int.Parse(userInput3);
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
            _goals.Add(checklistGoal);
        }
    }

    void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string userInput = Console.ReadLine();
        int userSelection = int.Parse(userInput) - 1;

        if (userSelection >= 0 && userSelection < _goals.Count)
        {
            Goal goal = _goals[userSelection];       
            goal.RecordEvent();

            if (goal is ChecklistGoal checklistGoal)
            {
                int pointsEarned = goal.GetPoints();
                _score += pointsEarned;
                if (goal.IsComplete())
                {
                    pointsEarned = checklistGoal.GetBonus();
                    _score += pointsEarned;
                    Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points!");
                    Console.WriteLine($"You now have {_score} points.");
                }

                else 
                {
                    Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points!");
                    Console.WriteLine($"You now have {_score} points.");
                }
            }

            else if (goal is EternalGoal eternalGoal)
            {
                int pointsEarned = goal.GetPoints();
                _score += pointsEarned;
                Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_score} points.");
            }

            else if (goal.IsComplete())
            {
                int pointsEarned = goal.GetPoints();
                _score += pointsEarned;
                Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_score} points.");
            }
        }
    }

    void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string userFile = Console.ReadLine();

        string fileName = $"{userFile}.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
    
            foreach (Goal goal in _goals)
            {
                string currentGoals = goal.GetStringRepresentation();
                outputFile.WriteLine(currentGoals);
            }

            Console.WriteLine($"\n{userFile} file has been successfully saved.");
        }
    }

    void AvailableFiles()
    {
        _txtFiles = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");

        if (_txtFiles.Length == 0)
        {
            Console.WriteLine("No goal files available to load.");
        }
        else
        {
            Console.WriteLine("\nAvailable goal files to load:");
            for (int i = 0; i < _txtFiles.Length; i++)
            {
                Console.WriteLine($"  {i + 1}. {Path.GetFileNameWithoutExtension(_txtFiles[i])}");
            }
        }
    }

    void LoadGoals()
    {
        AvailableFiles();
        Console.Write("Select a goal file to load: ");
        int fileSelected = int.Parse(Console.ReadLine()) - 1;

        if (fileSelected >= 0 && fileSelected < _txtFiles.Length)
        {
            string fileName = _txtFiles[fileSelected];
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                
                if (parts.Length == 1)
                {
                    int score = int.Parse(parts[0]);
                    _score = score;
                }

                else
                {
                    string goalType = parts[0];
                    string goalName = parts[1];
                    string goalDescription = parts[2];
                    int goalPoints = int.Parse(parts[3]);

                    if (goalType == "SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                        _goals.Add(simpleGoal);
                    }

                    else if (goalType == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                        _goals.Add(eternalGoal);
                    }

                    else if (goalType == "ChecklistGoal")
                    {
                        int goalTarget = int.Parse(parts[4]);
                        int goalBonus = int.Parse(parts[5]);
                        ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
                        _goals.Add(checklistGoal);
                    }
                }
            }
            Console.WriteLine($"\nFile has been successfully loaded.");
        }

        else 
        {
           Console.WriteLine("\nPlease select a valid goal file.");
           LoadGoals(); 
        }
    }
}