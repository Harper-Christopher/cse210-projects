using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNumberInput = Console.ReadLine();
            int userNumber = int.Parse(userNumberInput);
            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int userNumberSquared = userNumber * userNumber;
            return userNumberSquared;
        }

        static void DisplayResult(string userName, int userNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {userNumber}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }
}