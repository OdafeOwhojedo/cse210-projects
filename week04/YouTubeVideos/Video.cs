using System;
using System.Collections.Generic;

public class Video
{
    //public int Id;
    public string _videoTitle;
    public string _authorOfVideo;
    public int _lengthInSeconds;
    public Comment myComment;
    public List<Comment> _comments;

    public Video(string videoTitle, string authorOfVideo, int lengthInSeconds )
    {
        // Id = id;
        _videoTitle = videoTitle;
        _authorOfVideo = authorOfVideo;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountAllComments()
    {
        int numberOfComments = _comments.Count;
        return numberOfComments;
    }

    //public void DisplayVideoDetails()
    //{
       // Console.WriteLine($"------- Video: {Title} (ID: {Id}) ------");
       // Console.WriteLine($"Duration: {DurationInSeconds} second");
        //Console.WriteLine("\nComments:");
        //if (Comments.Count == 0)
        //{
           // Console.WriteLine(" No comments");
       // }
       // else
       // {
           // foreach (var comment in Comments)
            //{
               // comment.DisplayCommentDetails();
           // }
        //}
       // Console.WriteLine("------------------");
   // }

}