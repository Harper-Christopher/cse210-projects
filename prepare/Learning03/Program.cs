using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction createFraction = new Fraction();
        Console.WriteLine(createFraction.GetFractionString());
        Console.WriteLine(createFraction.GetDecimalValue());

        Fraction createFraction2 = new Fraction(5);
        Console.WriteLine(createFraction2.GetFractionString());
        Console.WriteLine(createFraction2.GetDecimalValue());

        Fraction createFraction3 = new Fraction(6, 7);
        Console.WriteLine(createFraction3.GetFractionString());
        Console.WriteLine(createFraction3.GetDecimalValue());
        Console.WriteLine(createFraction3.GetTop());
        Console.WriteLine(createFraction3.GetBottom());

        Console.Write("Please enter a number: ");
        string userTop = Console.ReadLine();
        int top = int.Parse(userTop);

        Console.Write("Please enter another number: ");
        string userBottom = Console.ReadLine();
        int bottom = int.Parse(userBottom);

        Fraction userFraction = new Fraction(top, bottom);
        Console.WriteLine(userFraction.GetFractionString());
        Console.WriteLine(userFraction.GetDecimalValue());
    }
}