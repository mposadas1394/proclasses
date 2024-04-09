using System;

public class OutdoorGathering:Event
{

    private string _weather;


    public OutdoorGathering(string title, string description,
    string date,string time,Adress address,
string weather):base(title, description, date, time,address)
     {
        _title=title;
        _description=description;
        _date=date;
        _weather=weather;
        _time=time;
        _address=address;
     }
     public void Details()
     {
        StandardDetails();
        Console.WriteLine($"Weather: {_weather}");
     }
     public void ThisShortDescription()
    {
        Console.WriteLine($"Event: Outdoor Gathering");
        ShortDescription();
    }

}