using System;
using System.IO;
public class EternalGoal: Goal
{
   
   
   
public EternalGoal( string name, string description, int points):base(name,description,points)
{
    _description=description;
    _shortName=name;
    _points=points;
}

    public override void RecordEvent(int score)
{
    score=score+_points;
    Console.WriteLine($"You got {_points} points");
}

public override string GetStringRepresentation()
{
string representation=$"EternalGoal:{_shortName},{_description},{_points}";
return representation;
}
}