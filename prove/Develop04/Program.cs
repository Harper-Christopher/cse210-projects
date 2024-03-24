//Created a counter to display at the end of the program to display how many times they used each activity.
//Also created a prompt if they select anything outside of the options given in the program, they'll get a message and the spinner will show. 
using System;

class Program
{
    static Activity activity = new Activity();
    static void Main(string[] args)
    {
        int userSelection = 0;
        while (userSelection != 4)
        {
            Menu menu = new Menu();
            Console.Write(menu.GetMenu());
            string userInput = Console.ReadLine();
            userSelection = int.Parse(userInput);

            if (userSelection == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity(activity);
                breathingActivity.Run();
            }

            if (userSelection == 2)
            {
                ReflectingActivity  reflectingActivity = new ReflectingActivity(activity);
                reflectingActivity.Run();
            }

            if (userSelection == 3)
            {
                ListingActivity listingActivity = new ListingActivity(activity);
                listingActivity.Run();
            }

            else
            {
                Console.WriteLine("\nInvalid selection, please select option 1 - 4 to continue.");
                activity.ShowSpinner(3);
            }
        }
        activity.DisplayProgramsCompleted();
    }
}