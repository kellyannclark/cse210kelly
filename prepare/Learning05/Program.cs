using System;

class Program
{
    static void Main(string[] args)
    {
       Square _square = new Square("blue", 5.0f);
       Console.WriteLine("Color: " + _square.GetColor());
       Console.WriteLine("Area: " + _square.GetArea());

       Square square = new Square("red", 3.0f);
       Rectangle rectangle = new Rectangle("green", 3.0f, 4.0f);
       Circle circle = new Circle("blue", 2.0f);

       Console.WriteLine("Square color: " + square.GetColor() + ", area: " + square.GetArea());
       Console.WriteLine("Rectangle color: " + rectangle.GetColor() + ", area: " + rectangle.GetArea());
       Console.WriteLine("Circle color: " + circle.GetColor() + ", area: " + circle.GetArea());
    }
}