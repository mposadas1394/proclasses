using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers=new List<int>();
        int userNumber=-1;
        
        while(userNumber!=0)
        {
            Console.WriteLine("Enter a number:");
            userNumber=int.Parse(Console.ReadLine());
            numbers.Add(userNumber);
        }
        int sum=numbers.Sum();
        double average=numbers.Average();
        int maxNumber=numbers.Max();
        Console.WriteLine("the sum is {0}", sum);
        Console.WriteLine("the average is {0}",average);
        Console.WriteLine("The largest is {0}",maxNumber);
    }
}