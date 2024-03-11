using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1=new Fraction();
        Console.WriteLine(fraction1.SetStringValue());
        Console.WriteLine(fraction1.SetDecimalValue());
        Fraction fraction2=new Fraction(5);
        Console.WriteLine(fraction2.SetStringValue());
        Console.WriteLine(fraction2.SetDecimalValue());
        Fraction fraction3=new Fraction(3,4);
        Console.WriteLine(fraction3.SetStringValue());
        Console.WriteLine(fraction3.SetDecimalValue());
        Fraction fraction4=new Fraction(1,3);
        Console.WriteLine(fraction4.SetStringValue());
        Console.WriteLine(fraction4.SetDecimalValue());
        
    }
}