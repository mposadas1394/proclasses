using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shapes=new List<Shapes>();

        shapes.Add(new Circle("red",45));
        shapes.Add(new Rectangle("blue", 5, 4));
        shapes.Add(new Square("orange",6));
        shapes.Add(new Circle("red",45));
        shapes.Add(new Rectangle("blue", 5, 4));
        shapes.Add(new Square("orange",6));
        shapes.Add(new Circle("red",45));
        shapes.Add(new Rectangle("blue", 5, 4));
        shapes.Add(new Square("orange",6));

        foreach (var item in shapes)
        {
            Console.WriteLine(item.GetColor());
            Console.WriteLine(item.GetArea());
            Console.WriteLine();
        }
    }
}