using System;
public class Writting:Assignment
{
    private string _title;

    public Writting(string name, string topic,string title):base(name,topic)
    {
        _title=title;
    }public string GetWrittingInformation()
    {
        return _title;
    }


}