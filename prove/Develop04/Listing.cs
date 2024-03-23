using System;

public class Listing: Activities
{
    private List<string>_prompts=new List<string>()
{"When you felt the Holy Ghost las month?",
"How many times you could say God was present last year?",
"Did you have opportunities to help others and didn`t do something for them?",
"What did your learn from the last general conference?",
"Something you are grateful for"
};

public Listing()
{
    _name="Listing Activity";
    _description="This activity will help you reflect on the good thingsin your life by having you list as many things as you can in a certain area.";
}
    public void Run()
    {
        Console.WriteLine("Get Ready...");
        Thread.Sleep(3000);
        
       
            Console.WriteLine("List as many responses you can to the following prompt");
            Thread.Sleep(2000);
            DisplayRandomPrompt();
            Thread.Sleep(2000);
            Console.Write("You may begin in...");
            CountDown();
            Console.WriteLine();
            GetListFromUser();
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
    int index = random.Next(_prompts.Count);
    string currPrompt = _prompts[index];
    return currPrompt;
    }
    public void DisplayRandomPrompt()
    {
        string prompt=GetRandomPrompt();
        Console.WriteLine(prompt);
    }
    public void GetListFromUser()
    {
        DateTime startTime= DateTime.Now;
        DateTime future=startTime.AddSeconds(_seconds);
        List<string>userList=new List<string>();
        while(DateTime.Now<future)
        {
            Console.Write(">");
            string answer=Console.ReadLine();
            userList.Add(answer);
            
        }
        int items=userList.Count;
        Console.WriteLine($"Your listed {items} items");
        
    }
}