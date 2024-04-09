using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos= new List<Video>();
        Video video1= new Video("Seleccion Argentina","Messi",300);
        videos.Add(video1);
        video1.AddComment("Matias","What a wonderful video");
        video1.AddComment("Luisa","I love Messi");
        video1.AddComment("Carla", "I love soccer");
        Video video2= new Video("Russel M. Nelson","LDS",500); 
        videos.Add(video2);
        video2.AddComment("Roger","What a nice message");
        video2.AddComment("Mark","I need that words");
        video2.AddComment("Jenn","I loved that talk");
        Video video3= new Video("Natural Desaster","Disovery Channel",350);
        videos.Add(video3);
        video3.AddComment("Louis","Wooooow");
        video3.AddComment("Steve","Incredible!");
        video3.AddComment("Carl","I`m gonna try to keep myself far from that place");
        video3.AddComment("Mary","Unbealiveable");


        int count=1;
        foreach (var item in videos)
        {
           
            Console.WriteLine($"Video: {count}");
            item.DisplayVideo();
            Console.WriteLine("");
            count++;
        }
    }
}   