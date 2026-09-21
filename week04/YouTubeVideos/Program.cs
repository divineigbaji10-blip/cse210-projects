using System;

class Program
{
    static void Main(string[] args)
    {
        Video myVideo = new Video("Eating the craziest food", "Igbaji Divine", 53);

        Comment myComment = new Comment("Annabel Tuna", "Oh my gosh! That is disgusting.");
        myVideo.AddComment(myComment);

        Comment myComment1 = new Comment("ReallyCrazyGirl", "Definitely AI, not good at all.");
        myVideo.AddComment(myComment1);

        Comment myComment2 = new Comment("LilNosy", "Bro, where do you even find food like this.");
        myVideo.AddComment(myComment2);




        Video myVideo1 = new Video("Tips that make you have long hair", "Lauryn Teddy", 102);

        Comment myComment3 = new Comment("IAmBlue", "This fake, I tried it, didn't work.");
        myVideo1.AddComment(myComment3);

        Comment myComment4 = new Comment("CandyGirl", "Try putting rice water on your hair.");
        myVideo1.AddComment(myComment4);

        Comment myComment5 = new Comment("Thanos", "You can try my product, it strengthens your hair and makes it super long.");
        myVideo1.AddComment(myComment5);




        Video myVideo2 = new Video("How to read for an exam in 5 minutes", "Paul Steven", 121);

        Comment myComment6 = new Comment("Prince", "There's no way that can happen.");
        myVideo2.AddComment(myComment6);

        Comment myComment7 = new Comment("Tina Laura", "Stop spreading fake videos.");
        myVideo2.AddComment(myComment7);

        Comment myComment8 = new Comment("Maria", "The world is coming to an end.");
        myVideo2.AddComment(myComment8);


        List<Video> videos = new List<Video>();
        videos.Add(myVideo);
        videos.Add(myVideo1);
        videos.Add(myVideo2);
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Comments: {video.NumberOfComments()}");
            Console.WriteLine();
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
        }
    }
}