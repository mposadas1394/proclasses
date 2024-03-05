using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int grade; string letter;
        Console.WriteLine("What`s your grade?");
        grade=Convert.ToInt16(Console.ReadLine());
        if(grade>=90){ 
            letter= "A";
        }
        else if(grade>=80){ 
            letter= "B";
        }
        else if(grade>=70){ 
            letter= "C";
        }
        else if(grade>=60){ 
            letter= "D";
        }
        else{
            letter= "F";
        }
        if(grade>=70){
            Console.WriteLine("You passed the course");
        }
        else{Console.WriteLine("I`m sorry, You didn`t pass the course");}
        Console.WriteLine("You got a {0}",letter);
    }
   
   
        
    

}