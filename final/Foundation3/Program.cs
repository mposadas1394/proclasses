using System;

class Program
{
    static void Main(string[] args)
    {
       string name=Console.ReadLine();
        Console.WriteLine("Street Address:");
        string street=Console.ReadLine();
        Console.WriteLine("City: ");
        string city=Console.ReadLine();
        Console.WriteLine("State/Province");
        string state=Console.ReadLine();
        Console.WriteLine("Country: ");
        string country=Console.ReadLine();

        Adress adress=new Adress(street,city,state,country);
        Console.WriteLine("Complete the following information about you event:");
        Console.WriteLine("What`s the name of your event");
        string title= Console.ReadLine();
        Console.WriteLine("What will your event be about?");
        string description=Console.ReadLine();
        Console.WriteLine("When do you like your event to be done?");
        string date=Console.ReadLine();
        Console.WriteLine("What`s the duration in hours you want it to be carried out");
        string time=Console.ReadLine();
        Console.WriteLine("What kind of event do you want");
        Console.WriteLine("1.Lecture");
        Console.WriteLine("2.Reception");
        Console.WriteLine("3.Outdoor gathering");
        string answer=Console.ReadLine();
        if (answer=="1")
        {
            Console.WriteLine("Who will be your speaker?");
            string speaker=Console.ReadLine();
            Console.WriteLine("How much peaple will attend to the event?");
            string quantity = Console.ReadLine();

            Lectures lectures=new Lectures(title,description,date,time,adress,speaker,quantity);
            Console.WriteLine("These are de details of your event");
            lectures.Details();
        }
        else if (answer=="2")
        {
            Console.WriteLine("We are going to need an email for RSVP");
            string email=Console.ReadLine();
            Receptions receptions=new Receptions(title,description,date,time, adress, email);
            Console.WriteLine("These are de details of your event");
            receptions.Details();
        }
        else
        {
            Console.WriteLine("We need you to add some information about the weather for the day you`ve chosen for your even so we can be aware of some issues as needed");
            string weather=Console.ReadLine();
            OutdoorGathering outdoorGathering=new OutdoorGathering(title,description,date, time, adress, weather);
            Console.WriteLine("These are de details of your event");
            outdoorGathering.Details();
        }

    }
}






