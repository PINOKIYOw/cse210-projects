using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> Comments = new List<Comment>();

    public int commentNumber()
    {
        return Comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of comments: {commentNumber()}");
    }
}