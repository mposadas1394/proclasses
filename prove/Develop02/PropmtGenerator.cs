using System;
using System.Collections.Generic;

public class PromtGenerator
{
    public List<string> _prompts = new List<string>(){
        "What was meaningful today?: ",
        "What was a challenge today?: ",
        "Who did you come across today that was interesting: ",
        "Did you feel somthing went so good?: ",
        "What about the things you did today, could go better tomorrow?: "
    };
    

    //Behavior
    public string Display()
    {
        Random random = new Random();
    int index = random.Next(_prompts.Count);
    string currPrompt = _prompts[index];
    return currPrompt;
    }
    
}