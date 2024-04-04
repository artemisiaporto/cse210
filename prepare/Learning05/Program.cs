using System;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sqr = new Square("Red",5);
        shapes.Add(sqr);
        //string colors1 = sqr.GetColor();
        //double areas1 = sqr.GetArea();
        //Console.WriteLine($"The color is {colors1}.");
        //Console.WriteLine($"The area is {areas1} m².");

        Rectangle rec = new Rectangle("Green",5,4);
        shapes.Add(rec);
        //string colors2 = rec.GetColor();
        //double areas2 = rec.GetArea();
        //Console.WriteLine($"The color is {colors2}.");
        //Console.WriteLine($"The area is {areas2} m².");

        Circle circ = new Circle("Blue",5);
        shapes.Add(circ);
        //string colors3 = circ.GetColor();
        //double areas3 = circ.GetArea();
        //Console.WriteLine($"The color is {colors3}.");
        //Console.WriteLine($"The area is {areas3} m².");

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = Math.Round(shape.GetArea(), 2);
            Console.WriteLine($"The {color} shape has an area of {area} m².");
        }
    }
}