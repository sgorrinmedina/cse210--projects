using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a list to hold videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Introduction to C#", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very clear explanation."));
        video1.AddComment(new Comment("Charlie", "Helped me a lot!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Advanced .NET Concepts", "Jane Smith", 1200);
        video2.AddComment(new Comment("David", "A bit complex, but insightful."));
        video2.AddComment(new Comment("Eve", "Looking forward to more videos!"));
        video2.AddComment(new Comment("Frank", "Excellent deep dive."));
        video2.AddComment(new Comment("Grace", "Could you explain more about async/await?"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Web Development with ASP.NET Core", "Mike Johnson", 900);
        video3.AddComment(new Comment("Heidi", "Perfect for beginners!"));
        video3.AddComment(new Comment("Ivan", "Loved the practical examples."));
        video3.AddComment(new Comment("Judy", "Highly recommended."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Data Structures in C#", "Sarah Brown", 1500);
        video4.AddComment(new Comment("Kevin", "The best explanation of linked lists I've seen."));
        video4.AddComment(new Comment("Liam", "Very thorough."));
        video4.AddComment(new Comment("Mia", "Thank you for this!"));
        videos.Add(video4);

        // Iterate through the list of videos and display their information
        foreach (Video video in videos)
        {
            Console.WriteLine($"\nTitle: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"  - {comment._commenterName}: {comment._commentText}");
            }
        }
    }
}
