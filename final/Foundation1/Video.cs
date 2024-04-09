using System;

public class Video
{
    private string _title;
    private string _author;
    private int _lenght;
    List<Comment>_comments=new List<Comment>();


    public Video (string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
    }
    public void AddComment(string name, string comment)
    {
        Comment comment1=new Comment(name, comment);
        _comments.Add(comment1);
    }

    public void DisplayNumberOfComments()
    {
        int count=_comments.Count;
        Console.WriteLine($"Comments ({count})");
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Lenght: {_lenght}");
        DisplayNumberOfComments();
        foreach (var item in _comments)
        {
            item.DisplayComment();
        }
    }
}