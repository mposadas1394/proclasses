using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
       
         Reference passage=new Reference("juan",5, 12);
         string text= "The quick brown fox jumps over the lazy dog.";
         Scripture content= new Scripture(passage,text);
         string answer=" ";
         bool isHidden=false;
         do
         {content.GetDisplayScripture();
         content.HideRandomWords(3);
         Console.WriteLine(" ");
         Console.WriteLine(" ");
         Console.WriteLine("To continue press any key or to finish, type `quit` ");
         answer=Console.ReadLine();
         isHidden=content.IsCompletelyHidden();
         }while((answer!="quit")&&(isHidden!=true) );
         
    }
}