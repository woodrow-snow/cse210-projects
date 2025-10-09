using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(2, "red");
        Rectangle rect = new Rectangle(2, 5, "blue");
        Circle circ = new Circle(2, "green");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rect);
        shapes.Add(circ);

        foreach (Shape shp in shapes)
        {
            Console.WriteLine($"Area: {shp.GetArea()}\nColor: {shp.GetColor()}");
            Console.WriteLine(""); //break line
        }
    }
}