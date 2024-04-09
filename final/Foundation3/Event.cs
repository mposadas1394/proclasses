using System;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;

    protected string _time;
    protected Adress _address;

protected Event(string title, string description,string date,string time,Adress address)
{
    _title = title;
    _description = description;
    _date = date;
    _time = time;
    _address = address;
}

protected void StandardDetails ()
{
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Description: {_description}");
    Console.WriteLine($"Date: {_date}");
    Console.WriteLine($"Time: {_time}");
}
protected void ShortDescription()
{
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Date: {_date}");
}

}

