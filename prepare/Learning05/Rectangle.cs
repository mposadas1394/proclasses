using System;

public class Rectangle:Shapes
{
    private float _width;
    private float _height;

public Rectangle(string color, float height,float width):base()
{
    _color=color;
    _height=height;
    _width=width;
}

    public override double GetArea()
    {
        return _height*_width;
    }
}