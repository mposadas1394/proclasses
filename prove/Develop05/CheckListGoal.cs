using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
public class CheckListGoal:Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description,int points,int target,int bonus):base(name, description,points)
    {
        _description=description;
        _shortName=name;
        _points=points;
        _bonus=bonus;
        _amountCompleted=0;
        _target=target;
        
    }
    public CheckListGoal(string name, string description,int points,int amountCompleted, int target,int bonus):base(name, description,points)
    {
        _description=description;
        _shortName=name;
        _points=points;
        _bonus=bonus;
        _amountCompleted=amountCompleted;
        _target=target;
        
    }
    public override void RecordEvent(int score)
    {
        _amountCompleted++;
        score= score+_points;
        Console.WriteLine($"You got {_points}  points");
        if (_target==_amountCompleted)
        {
            score+=_bonus;
            Console.WriteLine($"You got a bonus of{_bonus} points");
        }
        
    }

    public override string GetStringRepresentation() 
    {
        string representation=$"CheckListGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
        return representation;
    }
    public override string GetDetailsString()
    {
        if (_amountCompleted==_target)
        {
            return $"[x]{_shortName}({_description})-- Completed {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ]{_shortName}({_description})-- Completed {_amountCompleted}/{_target}";
        }
        
    }
}