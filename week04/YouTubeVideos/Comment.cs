using System;
public class Comment
{
    public int Id;
    public int VideoId;
    public string Author;
    public string Text;
    public DateTime Timestamp;

    public Comment(int id, int viewedVideoId, string author, string text)
    {
        Id = id;
        VideoId = viewedVideoId;
        Author = author;
        Text = text;
        Timestamp = DateTime.Now;
    }

    public void DisplayCommentDetails()
    {
        Console.WriteLine($"  - [{Timestamp.ToString("yyyy-MM-dd HH:mm")}] {Author}: {Text}"); 
    }

}