
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Rectangle(25, 5),
            new Triangle(15, 5),
            new Circle(9)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"El área del {shape.GetType().Name} es: {shape.CalculateSurface()}");
        }
    }
}





public abstract class Shape
{
    public double Alto { get; set; }
    public double Ancho { get; set; }

    public Shape(double alto, double ancho)
    {
        Alto = alto;
        Ancho = ancho;
    }

    public abstract double CalculateSurface();


}

class Rectangle : Shape
{
    public Rectangle(double alto, double ancho) : base(alto, ancho) { }

    public override double CalculateSurface()
    {
        return Alto * Ancho;
    }
}


class Triangle : Shape
{
    public Triangle(double alto, double ancho) : base(alto, ancho) { }

    public override double CalculateSurface()
    {
        return Alto * Ancho /2;
    }
}

class Circle : Shape
{
    public Circle(double radius) : base(radius, radius) { }

    public override double CalculateSurface()
    {
        return Math.PI * (Alto * Alto);
    }
}