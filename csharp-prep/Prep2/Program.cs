using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percent? ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);
        string letter;

        if (gradePercent >= 90) 
        {
            letter = "A";
        }
        else if (gradePercent >= 80) 
        {
            letter = "B"; 
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60) 
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

       
        string sign;
        int last_digit = gradePercent % 10;

        if (last_digit >= 7)
        {
            sign = "+";
        }
        else if (last_digit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        
        if (gradePercent >= 93)
        {
            sign = "";
        }
       
        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Stay focused and you'll get it next time!");
        }
    }
}