using System;

public class Receptions:Event
{
    private string _email;


    public Receptions(string title, string description,
    string date,string time,Adress address,
string email):base(title, description, date, time,address)
     {
        _title=title;
        _description=description;
        _date=date;
        _email=email;
        _time=time;
        _address=address;
     }

     public void Details()
     {
        StandardDetails();
        Console.WriteLine($"Email for RSVP: {_email}");
     }
     public void ThisShortDescription()
    {
        Console.WriteLine($"Event: Reception");
        ShortDescription();
    }

}