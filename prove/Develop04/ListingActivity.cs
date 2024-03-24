public class ListingActivity : Activity
{
    private int _count;
    private int _duration;
    List<string> _prompts = new List<string>();
    private Activity _activity;

    public ListingActivity(Activity activity)
    {
        _activity = activity;
    }
    
    public void Run()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        DisplayStartingMessage();
        _duration = GetDuration();
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin in: ");
        ShowCountDown(7);
        Console.WriteLine();
        _count = GetListFromUser().Count;
        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
        _activity.ListingCount(1);
    }

    public string GetRandomPrompt()
    {
        _prompts.Add("---Who are people that you appreciate?---");
        _prompts.Add("---What are personal strengths of yours?---");
        _prompts.Add("---Who are people that you have helped this week?---");
        _prompts.Add("---When have you felt the Holy Ghost this month?---");
        _prompts.Add("---Who are some of your personal heros?---");

        Random randomQuestion = new Random();
        int randomIndex = randomQuestion.Next(_prompts.Count);

        return _prompts[randomIndex];
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userResponse = Console.ReadLine();
            userList.Add(userResponse);
        }
        return userList;
    }
}