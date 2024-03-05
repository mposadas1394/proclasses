using System;

class Program
{
    static void Main(string[] args)
    {
         string firstName,lastName;
        Console.WriteLine("What`s your first name?");
        firstName= Console.ReadLine();
        Console.WriteLine("What`s your last name?");
        lastName=Console.ReadLine();
        Console.WriteLine("your name is {1}, {0} {1}",firstName,lastName);
    }
}