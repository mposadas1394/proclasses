using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal=new Journal();
        int answer=-1;
        string note="";
        string propmt="";
        string fileName="";
        do
        {
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Save");
            Console.WriteLine("4.Load");
            Console.WriteLine("5.Quit");
            Console.WriteLine(" ");
            Console.WriteLine("Select an option:");
            answer=int.Parse(Console.ReadLine());

            switch(answer)
            {
                case 1:
                propmt=new PromtGenerator().Display();
                Console.WriteLine(propmt);
                note=Console.ReadLine();
                
                break;
                case 2: 
                myJournal.DisplayAll();
                break;
                case 3:
                Console.WriteLine("how would you like this note?: ");
                fileName=Console.ReadLine();
                myJournal.AddEntry(propmt,note,fileName);
                Console.WriteLine("Your note was saved suesfully");
                break;
                case 4:myJournal.LoadFromFile();
                break;

            }
        }
        while(answer!=5);
        
        
        

        
    }
    
}