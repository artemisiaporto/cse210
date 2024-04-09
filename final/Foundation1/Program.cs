using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        List<Comment> comments1 = new List<Comment>();
        comments1.Clear();
        Comment v1comment1 = new Comment();
        v1comment1.SetInfo("Aurora", "I do liked the video. It helped me to sleep better.");
        comments1.Add(v1comment1);

        Comment v1comment2 = new Comment();
        v1comment2.SetInfo("Anthony", "I was able to scape the chaos and find inner calm.");
        comments1.Add(v1comment2);

        Comment v1comment3 = new Comment();
        v1comment3.SetInfo("Ariel", "Thanks to this video I unwinded and found peace within.");
        comments1.Add(v1comment3);
        
        Video video1 = new Video();
        video1.SetInfo("Guided Meditation", "John - Mental Helper", 300, comments1);
        videos.Add(video1);

        List<Comment> comments2 = new List<Comment>();
        Comment v2comment1 = new Comment();
        v2comment1.SetInfo("Aurora", "Exciting advancements featured here!");
        comments2.Add(v2comment1);

        Comment v2comment2 = new Comment();
        v2comment2.SetInfo("Anthony", "Amazing tech innovations showcased!");
        comments2.Add(v2comment2);

        Comment v2comment3 = new Comment();
        v2comment3.SetInfo("Ariel", "Impressive glimpse into future tech!");
        comments2.Add(v2comment3);

        Video video2 = new Video();
        video2.SetInfo("Innovative Tech", "New Developers Group", 250, comments2);
        videos.Add(video2);
        
        List<Comment> comments3 = new List<Comment>();

        Comment v3comment1 = new Comment();
        v3comment1.SetInfo("Elza", "Mesmerizing! This video captures the serene majesty of the sea in a breathtaking way.");
        comments3.Add(v3comment1);

        Comment v3comment2 = new Comment();
        v3comment2.SetInfo("Anna", "Watching this video is like taking a soothing journey through nature's wonders.");
        comments3.Add(v3comment2);

        Comment v3comment3 = new Comment();
        v3comment3.SetInfo("Elizabeth", "This video is a stunning reminder of the vast and mysterious beauty that lies beneath the waves.");
        comments3.Add(v3comment3);

        Video video3 = new Video();
        video3.SetInfo("The Beautiful Ocean", "Ocean Researchers", 350, comments3);
        videos.Add(video3);
        
        List<Comment> comments4 = new List<Comment>();

        Comment v4comment1 = new Comment();
        v4comment1.SetInfo("Benjamin", "Heartwarming reminder to cherish family moments!.");
        comments4.Add(v4comment1);

        Comment v4comment2 = new Comment();
        v4comment2.SetInfo("John", "Tears of joy watching this beautiful tribute to family.");
        comments4.Add(v4comment2);

        Comment v4comment3 = new Comment();
        v4comment3.SetInfo("James", "Touching portrayal of the precious bond in families.");
        comments4.Add(v4comment3);

        Video video4 = new Video();
        video4.SetInfo("Family is precious", "Family Society", 400, comments4);
        videos.Add(video4);
        
        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine("These are the video information:");
            Console.WriteLine($"Title: {video._title} | Author: {video._author} | Length[seconds]: {video._length}");
            Console.WriteLine();
            Console.Write($"The number of comments in this video is {video.NumberOfComments(comments1)}. ");
            Console.WriteLine("These are the comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"Person: {comment._personName} | Comment: {comment._comment}"); 
            }
        }
    }
}