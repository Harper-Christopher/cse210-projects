using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Blue", 4));
        shapes.Add(new Rectangle("Purple", 7, 10));
        shapes.Add(new Circle("Green", 5));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The shape is {color} with an area of {area}");
        }
    }
}