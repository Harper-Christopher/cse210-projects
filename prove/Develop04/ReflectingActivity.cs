using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();
    private int _duration;
    private Activity _activity;
    public ReflectingActivity(Activity activity)
    {
        _activity = activity;
    }
    
    public void Run()
    { 
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        DisplayStartingMessage();
        _duration = GetDuration();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
        _activity.ReflectingCount(1);
    }

    public string GetRandomPrompt()
    {
        _prompts.Add("---Think of a time when you stood up for someone else.---\n"); 
        _prompts.Add("---Think of a time when you did something really difficult.---\n"); 
        _prompts.Add("---Think of a time when you helped someone in need.---\n"); 
        _prompts.Add("---Think of a time when you did something truly selfless.---\n"); 
        _prompts.Add("---Think of a significant failure or setback that led to personal growth.---\n"); 
        _prompts.Add("---Think of a time when you took a leap of faith into the unknown.---\n"); 
        _prompts.Add("---Think of a time when you made a significant sacrifice for the benefit of others.---\n"); 
        _prompts.Add("---Think of an act of kindness that left a lasting impression on both you and the recipient.---\n"); 
        _prompts.Add("---Think of a moment when you demonstrated empathy and understanding towards someone going through a difficult time.---\n"); 
        _prompts.Add("---Think of a time when you exemplified the true essence of selflessness by putting the needs of others before your own desires.---\n"); 
        
        Random randomPrompt = new Random();
        int randomIndex = randomPrompt.Next(_prompts.Count);

        return _prompts[randomIndex];
    }

    public string GetRandomQuestion()
    {
        _questions.Add("> Why was this experience meaningful to you?");
        _questions.Add("> Have you ever done anything like this before?");
        _questions.Add("> How did you get started?");
        _questions.Add("> How did you feel when it was complete?");
        _questions.Add("> What made this time different than other times when you were not as successful?");
        _questions.Add("> What is your favorite thing about this experience?");
        _questions.Add("> What could you learn from this experience that applies to other situations?");
        _questions.Add("> What did you learn about yourself through this experience?");
        _questions.Add("> How can you keep this experience in mind in the future?");
        
        Random randomQuestion = new Random();
        int randomIndex = randomQuestion.Next(_questions.Count);

        return _questions[randomIndex];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(7);

        while (DateTime.Now < endTime)
        {
            Console.Write($"\n{GetRandomQuestion()}");
            ShowSpinner(7);
        }
    }
}