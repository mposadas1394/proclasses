using System;
using System.IO;
public abstract class Goal
{

   protected string _shortName;
   protected string _description;
   
   protected bool _IsComplete=false;
   protected int _points;
   public int _order;
   public Goal( string name, string description, int points)
   {
    _shortName=name;
    _description=description;
    _points=points;
    _order=0;
   }
   public abstract void RecordEvent(int score); 
   
   public virtual string GetDetailsString()
   {
      if (_IsComplete==true)
      {
         return$"[x]{_shortName}({_description})";
      }
      else
      {
         return $"[ ]{_shortName}({_description})";
      }
   }
   
   public abstract string GetStringRepresentation();

}