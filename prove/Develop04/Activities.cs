using System;

public class Activities
{
    protected string _name="";

    protected string _description="";

    protected int _seconds=0;

     protected List<string> characters=new List<string>()
    {"|","/","-","\\ ","|","/","-","\\"
    };

 public void DisplayStartMessage()
 {
   Console.WriteLine("Get Ready...");
   ShowSpinner();
   Console.WriteLine($"Welcome to the {_name}");
   Thread.Sleep(3000);
   Console.WriteLine(_description);
   Thread.Sleep(3000);
   Console.WriteLine("Huw much time en seconds would you like for this session");
   _seconds=int.Parse(Console.ReadLine());
   Console.Clear();
 }
 public void DisplayEndingMessage()
 {
    Console.WriteLine("Well done!");
    Thread.Sleep(5000);
    Console.WriteLine($"You`ve completed {_seconds} seconds of this session");
    ShowSpinner();
    Console.Clear();
 }
 protected void ShowSpinner()
 {
    DateTime startTime= DateTime.Now;
    DateTime future=startTime.AddSeconds(3);
    while (DateTime.Now<future)
    {
        foreach (var item in characters)
    {
        Console.Write(item);
        Thread.Sleep(300);
        Console.Write("\b\b");
    }
    }
 }
 protected void CountDown()
 {
    for (int i = 5; i >=0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000);
         Console.Write("\b \b");
    }
 }

}