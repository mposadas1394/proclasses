using System;

public class Word
{
    //Atributtes

    private string _text;
    public bool _isHidden;

    //Constructor

    public Word (string text)
    {
        _text=text;
    }

    //Behaviors
    public void Show()
    {
        Console.Write($"{_text} ");
    }

    public void Hide()
    {
        _text="______";
        _isHidden=true;
    }

    public bool IsHidden()
    {
        return true;
    }

    public void GetDisplayWord()
    {
        Console.Write($"{_text} ");
    }
}