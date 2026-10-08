using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(4, "Blue");
        Console.WriteLine(square1.GetColor());
        Console.WriteLine(square1.GetArea());

        Circle circle1 = new Circle(23, "Red");
        Console.WriteLine(circle1.GetColor());
        Console.WriteLine(circle1.GetArea());

        Rectangle rectangle1 = new Rectangle(3, 5, "Orange");
        Console.WriteLine(rectangle1.GetColor());
        Console.WriteLine(rectangle1.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(circle1);
        shapes.Add(rectangle1);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}