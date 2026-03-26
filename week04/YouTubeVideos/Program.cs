using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "C# Abstraction";
        video1._author = "Data Camp";
        video1._length = 360;

        Video video2 = new Video();
        video2._title = "C# for beginners";
        video2._author = "CodeCademy";
        video2._length = 300;

        Video video3 = new Video();
        video3._title = "Carribean Blue";
        video3._author = "Enya";
        video3._length = 145;

        video1.Comments.Add(new Comment("@peteroskin", "This has helped me so much."));
        video1.Comments.Add(new Comment("@oliviawilder", "Thanks alot!"));
        video1.Comments.Add(new Comment("@reesejarvin", "Please make more of these?"));

        video2.Comments.Add(new Comment("@tonystarks", "I'm still quite lost."));
        video2.Comments.Add(new Comment("@lukeskywalker", "You explained it so well."));
        video2.Comments.Add(new Comment("@jonjones", "Thanks for the help."));

        video3.Comments.Add(new Comment("@louisegraves", "What a beautiful song."));
        video3.Comments.Add(new Comment("@jacktim", "This touched my soul."));
        video3.Comments.Add(new Comment("@lawrencelanes", "I Love these kind of music videos."));

        DisplayVideo(video1);
        DisplayVideo(video2);
        DisplayVideo(video3);
    }

    static void DisplayVideo(Video video)
    {
        video.DisplayVideoInfo();
        Console.WriteLine("Comments: ");
        foreach (var Comment in video.Comments)
        {
            Comment.DisplayComment();
        }
        Console.WriteLine();
    }
}