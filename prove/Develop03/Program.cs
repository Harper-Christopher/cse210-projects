// Added the ability for the user to enter their own scripture verse. I also allowed them to chose how many words to hide at a time.
using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Console.Write("\nWould you like to enter your own scritpure verse to memorize? (yes/no) ");
        string userScripture = Console.ReadLine();

        if (userScripture == "yes")
        {
            Console.Write("Please enter the scriptures book name: ");
            string userBook = Console.ReadLine();
            Console.Write("Please enter the scriptures chapter: ");
            string chapterInput = Console.ReadLine();
            int userChapter = int.Parse(chapterInput);
            Console.Write("Please enter the srciptures verse: ");
            string verseInput = Console.ReadLine();
            int userVerse = int.Parse(verseInput);
            Console.Write("Please enter the context of the scripture: ");
            string userContext = Console.ReadLine();
            Console.Write("How many words would you like to hide each time? ");
            string hide = Console.ReadLine();
            int numberToHide = int.Parse(hide);
            Reference userReference = new Reference(userBook, userChapter, userVerse);
            Scripture scripture = new Scripture(userReference, userContext);

            while (userInput != "quit" && !scripture.IsCompletelyHidden())
            {
                Console.WriteLine(scripture.GetDisplayText());
                Console.Write("Press enter to continue or type 'quit' to finish: ");
                userInput = Console.ReadLine();
                scripture.HideRandomWords(numberToHide);
                Console.WriteLine(scripture.IsCompletelyHidden());
            }
            Console.WriteLine(scripture.GetDisplayText());
        }

        else if (userScripture == "no")
        {
            Reference reference = new Reference("Ether",12, 6, 7);
            Scripture scripture = new Scripture(reference, "\nAnd now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.");

            while (userInput != "quit" && !scripture.IsCompletelyHidden())
            {
                Console.WriteLine(scripture.GetDisplayText());
                Console.Write("Press enter to continue or type 'quit' to finish: ");
                userInput = Console.ReadLine();
                scripture.HideRandomWords(3);        
            }
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}