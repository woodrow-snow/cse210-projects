using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating Video List
        List<Video> videos = new List<Video>();

        // creating video 1 and comments
        Comment v1com1 = new Comment("John123", "This is good video");
        Comment v1com2 = new Comment("B!gMoneyB@gs", "Expert Quality");
        Comment v1com3 = new Comment("Joe", "Thank you!");

        List<Comment> v1ComList = new List<Comment>() { v1com1, v1com2, v1com3 };

        Video video1 = new Video("Look at this basket!", "BasketMaker12", 60 * 10, v1ComList);
        videos.Add(video1);

        // creating video 2 and comments
        Comment v2com1 = new Comment("David100", "I like this type of content!");
        Comment v2com2 = new Comment("BigHatguy", "0.o.0");
        Comment v2com3 = new Comment("UwUPerson", "i'm not going to do the thing");
        Comment v2com4 = new Comment("timothy", "Good Job on the basket!");

        List<Comment> v2ComList = new List<Comment>() { v2com1, v2com2, v2com3, v2com4 };

        Video video2 = new Video("Watch me make this basket!", "Basketball Dude", 60 * 60, v2ComList);
        videos.Add(video2);

        // creating video 3 and comments
        Comment v3com1 = new Comment("timothy", "Ohh that how you do that");
        Comment v3com2 = new Comment("BighatGuy", "^-^");
        Comment v3com3 = new Comment("Joe", "You rule!");
        Comment v3com4 = new Comment("Jacob", "Good video bro");
        Comment v3com5 = new Comment("user125r70", "...this is good...");

        List<Comment> v3ComList = new List<Comment>() { v3com1, v3com2, v3com3, v3com4, v3com5 };

        Video video3 = new Video("How to tie a tie", "Tie Bro", 60 * 12, v3ComList);
        videos.Add(video3);

        // going through video list and printing all information
        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetVideoInfo());
            Console.WriteLine("Comments...");
            video.PrintComments();

            // break line vvv
            Console.WriteLine();    
        }
    }
}