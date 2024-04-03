using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string userSeletion=" ";
        
        GoalManager App=new GoalManager();

        do
        {
            App.DisplayPlayerInfo();
            App.Start();
            userSeletion=Console.ReadLine();
            switch (userSeletion)
            {
                case "1":
                App.ListGoalNames();
                App.CreateGoal();
                break;
                case "2":
                App.ListGoalDetails();
                break;
                case "3":
                App.SaveGoals();
                break;
                case "4":
                App.LoadGoals();
                break;
                case "5":
                App.RecordEvent();
                break;
            }
        } while (userSeletion!="6");
    }
}