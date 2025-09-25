using System;
using System.Collections.Generic;

public class Video
{
    public string _videoTitle;
    public string _authorOfVideo;
    public int _lengthInSeconds;
    public Comment _userComment;
    public List<Comment> _comments;

    public Video(string videoTitle, string authorOfVideo, int lengthInSeconds )
    {
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


}