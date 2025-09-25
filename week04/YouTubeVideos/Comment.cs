using System;
public class Comment
{
   // public int Id;
   // public int VideoId;
    public string _nameOfCommenter;
    public string _commentText;
   // public DateTime Timestamp;

    public Comment(string nameOfCommenter, string commentText)
    {
        // Id = id;
        //VideoId = viewedVideoId;
        _nameOfCommenter = nameOfCommenter;
        _commentText = commentText;
        //Timestamp = DateTime.Now;
    }

    public string DisplayCommentDetails()
    {
        string displayComment = $" {_nameOfCommenter}: {_commentText}";
        return displayComment;
    }

}