using System;


class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("White", 3);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Yellow", 4, 3);
        shapes.Add(rectangle);

        Circle circle = new Circle("Red", 6);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }

}     