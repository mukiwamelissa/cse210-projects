using System;
using System.Collections.Generic;

class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }

    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics", "Nelson Williams", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Ben", "Very helpful."));
        video1.AddComment(new Comment("Larry", "Thanks for sharing."));
        videos.Add(video1);

        Video video2 = new Video("Web Development", "Merry Richardson", 900);
        video2.AddComment(new Comment("Junior", "Excellent explanation."));
        video2.AddComment(new Comment("Lissa", "I learned a lot."));
        video2.AddComment(new Comment("Mark", "Keep making videos!"));
        videos.Add(video2);

        Video video3 = new Video("Object-Oriented Programming", "Michael Daniels", 750);
        video3.AddComment(new Comment("Andy", "Well presented."));
        video3.AddComment(new Comment("Ella", "Very informative."));
        video3.AddComment(new Comment("Emmanuel", "Good examples."));
        videos.Add(video3);

        Video video4 = new Video("HTML and CSS", "Christina Maritz", 500);
        video4.AddComment(new Comment("Susan", "Easy to follow."));
        video4.AddComment(new Comment("Jacob", "Loved this lesson."));
        video4.AddComment(new Comment("Chris", "Thank you!"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}

