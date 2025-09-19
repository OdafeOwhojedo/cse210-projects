using System;
using System.Collections.Generic;

public class Video
{
    public int Id;
    public string Title;
    public int DurationInSeconds;
    public List<Comment> Comments;

    public Video(int id, string title, int durationInSeconds)
    {
        Id = id;
        Title = title;
        DurationInSeconds = durationInSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"------- Video: {Title} (ID: {Id}) ------");
        Console.WriteLine($"Duration: {DurationInSeconds} second");
        Console.WriteLine("\nComments:");
        if (Comments.Count == 0)
        {
            Console.WriteLine(" No comments");
        }
        else
        {
            foreach (var comment in Comments)
            {
                comment.DisplayCommentDetails();
            }
        }
        Console.WriteLine("------------------");
    }

}