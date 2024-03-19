using System;

class Program
{
    static void Main(string[] args)
    {
        //Assignment getting name and topic
        Assignment assignment = new Assignment();
        assignment.SetStudentName("Samuel Bennett");
        assignment.SetTopic("Multiplication");
        Console.WriteLine(assignment.GetSummary());

        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        //MathAssignment getting name, topic, textbook section, and problems
        MathAssignment mathAssignment = new MathAssignment();
        mathAssignment.SetStudentName("Joe Smith");
        mathAssignment.SetTopic("Multiplication");
        mathAssignment.SetTextbookSection("7.3");
        mathAssignment.SetProblems("8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        MathAssignment mathAssignment1 = new MathAssignment("Joe Smith", "Multiplication", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        //WritingAssignment 
        WritingAssignment writingAssignment = new WritingAssignment();
        writingAssignment.SetStudentName("Mary Waters");
        writingAssignment.SetTopic("European History");
        writingAssignment.SetTitle("The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}