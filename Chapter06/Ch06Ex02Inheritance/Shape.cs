namespace Packt.Shared;

public abstract class Shape
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double Area { get => CalculateArea(); }

    public abstract double CalculateArea();
}

public class Rectangle : Shape
{
    public Rectangle(double height, double width)
    {
        Height = height; Width = width;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Square : Shape
{
    public Square(double length)
    {
        Height = length;
        Width = length;
    }

    public override double CalculateArea()
    {
        return Math.Pow(Height, 2);
    }
}

public class Circle : Shape
{
    public Circle(double radius)
    {
        Height = radius;
        Width = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Height, 2);
    }
}