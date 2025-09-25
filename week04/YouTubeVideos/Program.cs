using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----------------YouTube Videos Information----------------");
        Video video1 = new Video("The benefits of daily physical exercise", "Dallot Davis", 420);
        Video video2 = new Video("The miracle of forgiveness", "Luke Charles", 780);
        Video video3 = new Video("The benefits of positive thinking", "Zenerb Mary", 544);
        Video video4 = new Video("You and personal revelations", "Franklin Benjamin", 622);


        Comment comment1 = new Comment("Alice Chris", "Great video, I am already enjoying the benefits of daily physical exercise, thanks for sharing.");
        Comment comment2 = new Comment("Bob Lewis", "Very helpful video");
        Comment comment3 = new Comment("Emeka Obi", "Thanks so much for this video, L learnt a lot and I intend to put your advice into action.");
        Comment comment4 = new Comment("Ojo Ade", "I am highly impressed with your video and I wish to express my gratitude for your divine teachings.");
        Comment comment5 = new Comment("Asatite Happiness", "You video exposed to me the power that comes from forgiving others and oneself");
        Comment comment6 = new Comment("John Wilcox", "Your knowledge of the subject matter of forgiveness has awaken my desire to forgive and be forgiven");
        Comment comment7 = new Comment("Bobby Benge", "Your video is very inspiring, we are indeed our thoughts");
        Comment comment8 = new Comment("FavouredMan", "I love the contents of your video, they actually made a very positive impression on me and my partner.");
        Comment comment9 = new Comment("David Otutugah", "I definitely learnt a lot from your video and I wish to appreciate you for the efforts you put in making this video. ");
        Comment comment10 = new Comment("Marley Lukeman", "Your video has encouraged me to do better to hear from the Lord.");
        Comment comment11 = new Comment("Juliet Ojo", "You did very well with the subject matter in this video and I have resolve to follow your instructions to hear from the Lord");
        Comment comment12 = new Comment("Charles N", "What a video, I am glad I came across this video at this very moment, I believe it is the Lord's wish for me.");


        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video4.AddComment(comment10);
        video4.AddComment(comment11);
        video4.AddComment(comment12);

        List<Video> myVideos = new List<Video>
        {
            video1, video2, video3, video4
        };
        foreach (Video video in myVideos)
        {
            Console.WriteLine($"Title of Video: {video._videoTitle}\nAuthor of Video: {video._authorOfVideo}\nLength of Video:{video._lengthInSeconds} seconds\nNumber of Comments: {video.CountAllComments()}");
            Console.WriteLine("-----------Comments-----------");
            foreach (var comment in video._comments)
            {
                Console.WriteLine($"Name: {comment._nameOfCommenter}\nComment: {comment._commentText}");
                Console.WriteLine();

            }
        }



    }
}