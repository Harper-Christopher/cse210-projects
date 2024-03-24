using System.ComponentModel;
using System.Data;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private int _breathingCompleted;
    private int _reflectingCompleted;
    private int _listingCompleted;

    public Activity()
    {

    }

    public void SetName(string name)
    {
        _name = name;
    }
    
    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string desciption)
    {
        _description = desciption;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void BreathingCount(int count)
    {
        _breathingCompleted += count;
    }

    public void ReflectingCount(int count = 1)
    {
        _reflectingCompleted += count;
    }

    public void ListingCount(int count = 1)
    {
        _listingCompleted += count;
    }

    public void DisplayProgramsCompleted()
    {
        Console.WriteLine($"\nYou have completed {_breathingCompleted} breathing activite(s), {_reflectingCompleted} reflecting activite(s), and {_listingCompleted} listing activitie(s) during this session.\n");
    }
    
    public void DisplayStartingMessage() 
    {
        Console.Write($"\nWelcome to the {_name} \n\n{_description}");
        Console.Write("\n\nHow long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput);
        Console.WriteLine("\nGet ready...");
        ShowSpinner(7);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell Done!!");
        ShowSpinner(7);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(7);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string spinner = animationStrings[i];
            Console.Write(spinner);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            //10 and over
            //Console.Write("\b\b  \b\b");
        }
    }
}