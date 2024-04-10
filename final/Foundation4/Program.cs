using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running("03 Nov 2022", 30, 9.0));
        activities.Add(new Cycling("09 June 2022", 30, 15.0));
        activities.Add(new Swimming("11 Aug 2022", 30, 50));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}