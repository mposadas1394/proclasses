using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
class Program
{
    static void Main(string[] args)
    {
       
         
         
         
         Reference passage=new Reference("John",10, 11,12);
         string text= "I am the good shepherd: the good shepherd giveth his life for the sheep.But he that is an hireling, and not the shepherd, whose own the sheep are not, seeth the wolf coming, and leaveth the sheep, and fleeth: and the wolf catcheth them, and scattereth the sheep.";
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
         
         Console.WriteLine(" ");
         Console.WriteLine(" ");

         if(answer=="quit")
         {
            Console.WriteLine("Good luck next chance");
         }
         if(isHidden==true)
         {
            Console.WriteLine("All words are hidden");
         }
    }
}