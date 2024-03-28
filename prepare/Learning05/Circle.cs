using System;
using System.Net.NetworkInformation;

public class Circle:Shapes
{
    private float _radius;


public Circle(string color, float radius):base()
{
    _color=color;
    _radius=radius;
}

    public override double GetArea()
    {
        return 3.14*(_radius*_radius);
    }
}