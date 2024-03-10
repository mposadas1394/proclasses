using System;
using System.Collections.Generic;
public class Entry
{
public string _date=Convert.ToString(new DateTime());


public string _promptText="";


public string _entryText="";

public string _file="";

// Behavior
public void Display()
{
    Console.WriteLine($"Date: {_date}");
    Console.WriteLine($"Prompt: {_promptText}");
    Console.WriteLine(_entryText);
}
}