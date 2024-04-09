using System;

public class Lectures: Event
{
    private string _speaker;
     
    private  string _capacity;

    public Lectures(string title, string description,
    string date,string time,Adress address,
    string speaker, string capacity):base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _title=title;
        _description=description;
        _date=date;
        _address=address;
        _time=time;
    }
    private void ThisDetails()
    {
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
    public void Details()
    {
        StandardDetails();
        ThisDetails();
    }
    public void ThisShortDescription()
    {
        Console.WriteLine($"Event: Lecture");
        ShortDescription();
    }

}