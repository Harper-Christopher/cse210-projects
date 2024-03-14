using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Reference reference = new Reference("Ether", 12, 27);
        Scripture scripture = new Scripture(reference, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");

        while (userInput != "quit")
        {
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
        }
    }
}