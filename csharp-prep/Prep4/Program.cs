using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        int number = 1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);

            if (number != 0)
            {
                numbersList.Add(number);
            }
        }

        int currentSum = 0;
        for (int i = 0; i < numbersList.Count; i++)
        {
            currentSum += numbersList[i];
        }
        float average = (float)currentSum / numbersList.Count;
        Console.WriteLine($"The sum is: {currentSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {numbersList.Max()}");
    }
}