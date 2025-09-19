using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video1 = new Video(1, "Introduction to C#", 300);
        Video video2 = new Video(2, "Advance C# Techniques", 600);

        Comment comment1 = new Comment(101, 1, "Alice", "Great explanation!");
        Comment comment2 = new Comment(102, 1, "Bob", "Very helpful.");
        Comment comment3 = new Comment(103, 2, "Dave", "Looking forward to the next one");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video2.AddComment(comment3);

        video1.DisplayVideoDetails();
        Console.WriteLine();
        video2.DisplayVideoDetails();

    }
}