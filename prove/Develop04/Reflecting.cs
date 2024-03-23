using System;

public class Reflecing:Activities
{
    private List<string> _prompts=new List<string>(){
"What was the most difficult thing you`ve ever done?",
"Is there something you`ve experience once in life that makes your mind change completely?",
"Whas is the achievement you are proud of the most?",
"Whats is the failure you`ve learned the most?",
"Is there somenthing you wanted it to be different but can`t? ",
};
   private List<string> _questions=new List<string>(){
    ">What do you learn from that?",
    ">If you could give an advice from that experiencie, what it would be?",
    ">Do you repent from that?",
    ">What is the best thing of that experience?",
    ">What is the worst thing of that?",
   };



    public Reflecing()
    {
        _name="Reflecting Activity";
        _description="This activity will help you reflect on times in your life when oyu have shown strength and resilience.This will help ypu recognize the power oyu have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DateTime startTime= DateTime.Now;
        DateTime future=startTime.AddSeconds(_seconds);
        while (DateTime.Now<future)
        {
            Console.WriteLine("Consider the following prompt");
            DisplayRandomPrompt();
            Console.WriteLine("When you have something in mind press enter");
            string answer=Console.ReadLine();
            Console.WriteLine("Now ponder on the following questions as they relatet to the experience");
            Console.Write("You may begin in:");
            CountDown();
            Console.Clear();
            DisplayRandomQuestion();
            ShowSpinner();
            Console.WriteLine();
            DisplayRandomQuestion();
            ShowSpinner();
        }
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
    int index = random.Next(_prompts.Count);
    string currPrompt = _prompts[index];
    return currPrompt;
    }
    private string GetRandomQuestion()
    {
       Random random = new Random();
    int index = random.Next(_questions.Count);
    string currPrompt = _questions[index];
    return currPrompt;
    }
    public void DisplayRandomQuestion()
    {
        string question=GetRandomQuestion();
        Console.WriteLine(question);
    }
    public void DisplayRandomPrompt()
    {
        string prompt=GetRandomPrompt();
        Console.WriteLine(prompt);
    }

}