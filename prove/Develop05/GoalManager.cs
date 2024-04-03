using System;
using System.IO;
public class GoalManager
{
private List<Goal> _goals;
public int _score;


public GoalManager()
{
    _score=0;
    _goals=new List<Goal>();
}

public void Start()
{
    Console.WriteLine("Menu options: ");
    Console.WriteLine("    1.Create a new Goal");
    Console.WriteLine("    2.List Goals");
    Console.WriteLine("    3.Save Goals");
    Console.WriteLine("    4.Load Goals");
    Console.WriteLine("    5.Record Goals");
    Console.WriteLine("    6.Quit");
    Console.WriteLine("Select a choice from the menu: ");
    
}
public void DisplayPlayerInfo()
{
Console.WriteLine($"You have {_score} points");
}

public void ListGoalNames()
{
    Console.WriteLine("The types of Goals are:");
    Console.WriteLine("    1.Simple Goals");
    Console.WriteLine("    2.Eternal Goals");
    Console.WriteLine("    3.CheckList Goals");
}

public void ListGoalDetails()
{
    int count=1;
    foreach (var item in _goals)
    {
        item._order=count;
        Console.WriteLine($"{count}. {item.GetDetailsString()}");
        count++;
    }
}

public void CreateGoal()
{
    string name="";
    string description="";
    int points=0;
    int target=0;
    int bonus=0;
    Console.WriteLine("Which kind of goal do you like to create?: ");
    string goal=Console.ReadLine();
    if (goal=="1"||goal=="2"||goal=="3")
    {
        Console.WriteLine("What is the name of the goal?: ");
         name=Console.ReadLine();
        Console.WriteLine("What is a short description of it?: ");
         description=Console.ReadLine();
        Console.WriteLine("What is the amount of pints assoiated with this goal?: ");
         points=int.Parse(Console.ReadLine());
    }
    if (goal=="3")
    {
    
        Console.WriteLine("How many times does this goal need to be acomplished for a bonus?: ");
        target=int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing that many times?: ");
        bonus=int.Parse(Console.ReadLine());
    }
    if (goal=="1")
    {
        SimpleGoal simpleGoal=new SimpleGoal(name,description,points);
        _goals.Add(simpleGoal);
    }
    if (goal=="2")
    {
        EternalGoal eternalGoal=new EternalGoal(name,description,points);
        _goals.Add(eternalGoal);
    }
    if (goal=="3")
    {
        CheckListGoal checkListGoal=new CheckListGoal(name,description,points, target, bonus);
        _goals.Add(checkListGoal);
    }
}

public void RecordEvent()
{   int count=1;
    Console.WriteLine("The goals are: ");
    foreach (var item in _goals)
    {
        Console.Write(count);
        Console.WriteLine(item.GetDetailsString());
        count++;
    }
        Console.WriteLine("What do you want to record?");
        int answer=int.Parse(Console.ReadLine());
        foreach (var item in _goals)
        {
            if (item._order==answer)
            {
                item.RecordEvent(_score);
            }   
        }
       
}

public void SaveGoals()
{
    string textFile;
    Console.WriteLine("What`s the name for the goal file?");
    textFile=Console.ReadLine();
    using (StreamWriter outputFile = new StreamWriter(textFile))
    {
        outputFile.WriteLine(_score);
        foreach (var item in _goals)
    {
           outputFile.WriteLine(item.GetStringRepresentation());
    }
    }

}

public void LoadGoals()
{
    Console.WriteLine("What`s the name of the file?:");
    string filename=Console.ReadLine();
    string[] lines = System.IO.File.ReadAllLines(filename);
    foreach (var line in lines)
    {
        string[] parts = line.Split(":");
        if (parts[0]=="SimpleGoal")
        {
            string[] parts2 = parts[1].Split(",");
            int points=int.Parse(parts2[2]);
            SimpleGoal simpleGoal=new SimpleGoal(parts2[0],parts2[1],points);
            _goals.Add(simpleGoal);
        }
        else if (parts[0]=="EternalGoal")
        {
            string[] parts2 = parts[1].Split(",");
            int points=int.Parse(parts2[2]);
            EternalGoal eternalGoal=new EternalGoal(parts2[0],parts2[1],points);
            _goals.Add(eternalGoal);
        }
        else if(parts[0]=="CheckListGoal")
        {
            string[] parts2 = parts[1].Split(",");
            int points=int.Parse(parts2[2]);
            int amountCompleted=int.Parse(parts2[3]);
            int target=int.Parse(parts2[4]);
            int bonus=int.Parse(parts2[5]);
            CheckListGoal checkListGoal=new CheckListGoal(parts2[0],parts2[1],points,amountCompleted,target,bonus);
            _goals.Add(checkListGoal);
        }
        else
        {
            _score=int.Parse(parts[0]);
        }
    }
}

}