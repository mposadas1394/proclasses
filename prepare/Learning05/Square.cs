using System;

public class Square:Shapes
{
    private float _side;


public Square(string color, float side):base()
{
    _side=side;
    _color=color;
}
    public override double GetArea()
    {
        return _side*_side;
    }
}