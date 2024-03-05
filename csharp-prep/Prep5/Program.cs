using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name=PromptUserName();
        int number=PromptUserNumber();
        int squared=SquareNumber(number);
        DisplayResult(name,squared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName(){
       Console.WriteLine("Please, enter your name:");
       string name=Console.ReadLine();
       return name;
    }
    static int PromptUserNumber(){
        Console.WriteLine("Please, enter a number: ");
        int number=int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number){
        int squared=number*number;
        return squared;
    }
    static void DisplayResult(string name,int number){
        Console.WriteLine("{0}, the square of your number is {1}",name,number);
    }
}