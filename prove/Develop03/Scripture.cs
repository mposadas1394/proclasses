using System;

public class Scripture
{
    private Reference _reference;

    private List<Word> words=new List<Word>();
    public Scripture( Reference reference,string text)
    {
        _reference= reference;
        
        string[] list=text.Split(" ");
        List<string> phraseList = new List<string>(list);

        foreach (var b in phraseList)
        {
            Word word= new Word(b);
            words.Add(word);
        }
        
        
    }
    
    public void HideRandomWords(int numberToHide)
    {
        Random random=new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(words.Count);
            var neWord=words[index];
            neWord.Hide();
        }
    
    }
    
    public void GetDisplayScripture()
    {
        _reference.GetDisplayTextReference();
        foreach (var item in words)
        {
            item.GetDisplayWord();
        }
       
    }

    public bool IsCompletelyHidden()
    {
        bool hasUndercores=words.All(element=>element._isHidden.Equals(true));
        return hasUndercores;
        
    }
}