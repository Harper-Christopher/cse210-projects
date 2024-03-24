public class BreathingActivity : Activity

{
    private int _duration;
    private Activity _activity;

    public BreathingActivity(Activity activity)
    {
        _activity = activity;
    }
    
    public void Run()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        DisplayStartingMessage();
        _duration = GetDuration();
    
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreath in...");
            ShowCountDown(5);
            Console.Write("\nNow breath out...");
            ShowCountDown(5);
            Console.WriteLine();
        }
        DisplayEndingMessage();    
        _activity.BreathingCount(1);
    }
}
