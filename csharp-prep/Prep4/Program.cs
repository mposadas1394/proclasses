using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.WriteLine("Enter a number: ");
        string answer=Console.ReadLine();
        int number=int.Parse(answer);
        while(number!=0){
            numbers.Add(number);
            Console.WriteLine("Enter a number: ");
            answer=Console.ReadLine();
            number=int.Parse(answer);
        }
        int sum=numbers.Sum();
        double average=numbers.Average();
        int max=numbers.Max();
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest is {max}");

    }
}