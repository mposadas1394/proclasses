using System;
using System.IO;
public class SimpleGoal:Goal
{
    private bool _isComplete;


public SimpleGoal( string name, string description, int points): base(name,description,points)
{
    _isComplete=false;
    _description=description;
    _shortName=name;
    _points=points;

}

public override void RecordEvent(int score)
{
    score=_points;
    _IsComplete=true;
    Console.WriteLine($"You got {_points} points");
}

public override string GetStringRepresentation()
{
string representation=$"SimpleGoal:{_shortName},{_description},{_points}";
return representation;
}


}