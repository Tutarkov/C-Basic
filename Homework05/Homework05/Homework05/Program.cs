using Inheritance.Models;

public class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Shape
        Shape shape = new Shape("shape", "red", new int[] { 0, 0 });
        Shape.move(shape);
        Console.WriteLine($"The new position of {shape.Color} {shape.Name} is ({shape.Position[0]}, {shape.Position[1]})");

        // Create an instance of Rectangle
        Rectangle rectangle = new Rectangle("rectangle", "green", new int[] { 10, 10 }, 5, 10);
        Shape.move(rectangle);
        Console.WriteLine($"The new position of {rectangle.Color} {rectangle.Name} is ({rectangle.Position[0]}, {rectangle.Position[1]})");
        rectangle.getArea();
        rectangle.getPerimeter();

        // Create an instance of Circle
        Circle circle = new Circle("circle", "blue", new int[] { 20, 20 }, 7);
        Shape.move(circle);
        Console.WriteLine($"The new position of {circle.Color} {circle.Name} is ({circle.Position[0]}, {circle.Position[1]})");
        circle.getArea();
        circle.getPerimeter();
    }
}