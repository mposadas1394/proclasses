using System;

public class Fraction
{
    //Atributtes
    private int _top;
    private int _bottom;

//Constructors
    public Fraction()
    {
        _top=1;
        _bottom=1;
    }
    public Fraction(int numerator)
    {
        _top=numerator;
        _bottom=1;
    }
    public Fraction(int numerator, int denominator)
    {
        _top=numerator;
        _bottom=denominator;
    }

    //Getter and Setter behaviors

    public string SetStringValue()
    {
        string fraction=$"{_top}/{_bottom}";
        return fraction;
    }
    public double SetDecimalValue()
    {
         
        return (double)_top/(double)_bottom;
    }
}