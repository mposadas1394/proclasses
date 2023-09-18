using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        Console.WriteLine("What´s your number?");
        string answer=Console.ReadLine();
        int response=int.Parse(answer);
        while(response!=number){
            if(response>number){
                Console.WriteLine("Lower");
                Console.WriteLine("What´s your number?");
                answer=Console.ReadLine();
                response=int.Parse(answer);
                }
            else if(response<number){
                Console.WriteLine("Higher");
                Console.WriteLine("What´s your number?");
                answer=Console.ReadLine();
                response=int.Parse(answer);
            }
        }
        Console.WriteLine("you guesed it");
        Console.WriteLine("Thanks for playing");               
    }
}