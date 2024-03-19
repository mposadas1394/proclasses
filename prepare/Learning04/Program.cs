using System;

class Program
{
    static void Main(string[] args)
    {

       Assignment assignment=new Assignment("Matias Posadas", "Fractions");
       Console.WriteLine(assignment.GetSummary()); 
    
       Math math=new Math("Matias Posadas","Fractions","24","5-18");
       Console.WriteLine(math.GetSummary());
       Console.WriteLine(math.GetHomeworkList());

       Writting writting=new Writting("Matias Posadas","History","The Causes of World War II by Mary Waters");
       Console.WriteLine(writting.GetSummary());
       Console.WriteLine(writting.GetWrittingInformation());

    }
}