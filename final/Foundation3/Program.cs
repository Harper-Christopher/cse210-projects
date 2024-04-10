using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lectures = new Lectures("David A. Bednar", 350);
        lectures.SetTitle("Consider the Wondrous Works of God");
        lectures.SetDescription("This marvelous work and a wonder of the latter days is spreading across the earth and enables you and me individually to become the works of God's work - even the results of His loving labor and divine direction.");
        lectures.SetDateTime("April 10th, 2024 @ 7pm");
        lectures.SetAddress("2265 W 700 S, Pleasant Grove, UT 84062");
        
        Console.WriteLine($"Lectures Standard Details: \n{lectures.GetStandardDetails()}\n");
        Console.WriteLine($"Lectures Full Details: \n{lectures.GetLectureDetails()}");
        Console.WriteLine($"Lectures Short Description: \n{lectures.GetShortDescription()}");

        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine();

        Receptions receptions = new Receptions("rsvp@gmail.com");
        receptions.SetTitle("General Conference Reception");
        receptions.SetDescription("Come feel the spirit while listening to a living prophet on earth today.");
        receptions.SetDateTime("April 7, 2024 @ 2pm");
        receptions.SetAddress("60 North Temple, Salt Lake City, UT 84150");

        Console.WriteLine($"Receptions Standard Details: \n{receptions.GetStandardDetails()}\n");
        Console.WriteLine($"Receptions Full Details: \n{receptions.GetReceptionDetails()}");
        Console.WriteLine($"Receptions Short Description: \n{receptions.GetShortDescription()}");

        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine();

        OutdoorGatherings outdoorGatherings = new OutdoorGatherings("sunny and 75\u00B0");
        outdoorGatherings.SetTitle("Temple Square Walk");
        outdoorGatherings.SetDescription("We will gather together to take a tour of the temple square grounds.");
        outdoorGatherings.SetDateTime("June 9, 2024 @ 6pm");
        outdoorGatherings.SetAddress("50 North Temple, Salt Lake City, UT 84150");

        Console.WriteLine($"Outdoor Gatherings Standard Details: \n{outdoorGatherings.GetStandardDetails()}\n");
        Console.WriteLine($"Outdoor Gatherings Full Details: \n{outdoorGatherings.GetOutdoorDetails()}");
        Console.WriteLine($"Outdoor Gatherings Short Description: \n{outdoorGatherings.GetShortDescription()}");
    }
}