using System;

class Program
{
    static void Main(string[] args)
    {
        string response;

        do
        {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        int amountGuessed = 1;

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int numberGuessed = int.Parse(guess);

        while (numberGuessed != magicNumber)
        {
            if (numberGuessed < magicNumber)
            {
                Console.WriteLine("Higher");
                amountGuessed = amountGuessed + 1;
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                numberGuessed = int.Parse(guess);
            }

            else if (numberGuessed > magicNumber)
            {
                Console.WriteLine("Lower");
                amountGuessed = amountGuessed + 1;
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                numberGuessed = int.Parse(guess);
            }
        }

        Console.WriteLine($"You guessed it! The magic number was {magicNumber}!");
        Console.WriteLine($"It took you {amountGuessed} guesses.");
        Console.Write("Would you like to play again? (yes/no) ");
        response = Console.ReadLine();
        } while(response == "yes");
    }
}