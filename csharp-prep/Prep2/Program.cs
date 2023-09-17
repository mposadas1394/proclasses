using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What´s your grade percentage");
        string response=Console.ReadLine();
        int grade=int.Parse(response);
        if (grade>=90){
            Console.WriteLine("You got an A");
        }
        else if(grade>=80){
            Console.WriteLine("You got an B");
        }
        else if(grade>=70){
            Console.WriteLine("You got a C");
        }
        else if(grade>=60){
            Console.WriteLine("You got a D");
        }
        else {
            Console.WriteLine("You got an F");
        }
        if(grade>=70){
            Console.WriteLine("Congratulations! You passed the course");
        }
        else{
            Console.WriteLine("Sorry, You didn´t pass. Try it again");
        }
    }
}