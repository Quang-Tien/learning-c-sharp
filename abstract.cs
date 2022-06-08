using System;


abstract class Shape
{
    public abstract double getArea();
    public abstract double getPerimeter();

}


class Circle : Shape
{
    double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double getArea()
    {
        return this.radius * this.radius * 3.14;
    }

    public override double getPerimeter()
    {
        return 2 * this.radius * 3.14;
    }
}

class Rectangle : Shape
{
    double width;
    double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public override double getArea()
    {
        return width * height;
    }

    public override double getPerimeter()
    {
        return 2 * (width + height);
    }
}


class Program
{
    static void Main(string[] args)
    {
        Circle c = new Circle(3.5);
        Rectangle r = new Rectangle(2.5, 3);

        Console.WriteLine(c.getArea());
        Console.WriteLine(c.getPerimeter());
        Console.WriteLine(r.getArea());
        Console.WriteLine(r.getPerimeter());

    }
}