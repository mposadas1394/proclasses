using System;

public class Breathing: Activities
{


public Breathing()
    {
       _name="Breathing Avtivity";
       _description="This activity will help you relax by walking you through your breathing in and out slowly.Clear your mind and focus on your breathing";
    }


    public void Run()
    {
        DateTime startTime= DateTime.Now;
        DateTime future=startTime.AddSeconds(_seconds);
        while (DateTime.Now<future)
        {
            Console.Write("Breath in ...");
            CountDown();
            Console.WriteLine("");
            Console.Write("Now breath out...");
            CountDown();
                Console.WriteLine(" ");
                Console.WriteLine(" ");
        }
        
    }
}