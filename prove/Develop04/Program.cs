using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string answer="";
       do
       {
        Menu();
        answer=Console.ReadLine();

        if (answer=="1")
        {
            Console.Clear();

            Breathing breathing=new Breathing();
            breathing.DisplayStartMessage();
            breathing.Run();
            breathing.DisplayEndingMessage(); 
        }
        else if(answer=="2")
        {
            Console.Clear();
            Reflecing reflecing=new Reflecing();
            reflecing.DisplayStartMessage();
            reflecing.Run();
            reflecing.DisplayEndingMessage();
        }
        else if(answer=="3")
        {
            Console.Clear();
            Listing listing=new Listing();
            listing.DisplayStartMessage();
            listing.Run();
            listing.DisplayEndingMessage();
        }
       } while (answer!="4");
    }

    static void Menu()
    {
        
        
        Console.WriteLine("1.Breathing");
        Console.WriteLine("2.Reflecing");
        Console.WriteLine("3.Listing");
        Console.WriteLine("4.Quit");
    }
}
 
        