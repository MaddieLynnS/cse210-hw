using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 4.0);
        Rectangle rect = new Rectangle("pink", 4.0, 5.0);
        Circle circle = new Circle("yellow", 3.0);

        shapes.Add(square);
        shapes.Add(rect);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}