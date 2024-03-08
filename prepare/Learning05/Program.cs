using System;

class Program
{
    static void Main(string[] args)
    {
         List<Shape> shapes = new List<Shape>{
            new Square("purple", 13),
            new Rectangle("orange", 10, .5),
            new Circle("black", 8.4)};

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}