using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    //Behaviors

    public void AddEntry( string prompt, string note, string fileName)
    {
        Entry _entry =new Entry();
        _entry._promptText=prompt;
        _entry._entryText=note;
        _entry._file=fileName;
        _entries.Add(_entry);


    }
    public void DisplayAll()
    {
        foreach( Entry b in _entries )
        {
            b.Display();
        }
    }
    public void LoadFromFile()
    {
        Console.WriteLine("Please, enter the file name you are looking for: ");
        string file= Console.ReadLine();
        foreach (Entry b in _entries)
        {
            if(b._file==file)
            {
                b.Display();
            }
        }
    }
}
