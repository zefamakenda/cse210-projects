using System;

class Program
{
    
    static void Main(string[] args) 
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project. - Program.cs:8");
        Console.WriteLine(); 


        List<Video> videos = new List<Video>(); 
        

        Video video1 = new Video("iPhone 15 Review", "TechReviewPro", 540);  
        video1.AddComment(new Comment("Alice", "Great review!"));  
        video1.AddComment(new Comment("Brian", "Very informative."));  
        video1.AddComment(new Comment("Cathy", "Helped me decide to buy."));  
        videos.Add(video1);  
        

        Video video2 = new Video("Top 5 Budget Laptops", "LaptopWorld", 720); 
        video2.AddComment(new Comment("Daniel", "Awesome list.")); 
        video2.AddComment(new Comment("Eva", "Which one is best for coding?")); 
        video2.AddComment(new Comment("Frank", "I bought number 3.")); 
        videos.Add(video2);
        

        Video video3 = new Video("Best Wireless Headphones", "SoundTech", 480); 
        video3.AddComment(new Comment("Grace", "Sound quality is amazing."));
        video3.AddComment(new Comment("Henry", "Battery life seems short."));
        video3.AddComment(new Comment("Isla", "Thanks for the comparison.")); 
        videos.Add(video3);
        

        foreach (Video video in videos)

        {
            
            Console.WriteLine($"Title: {video.GetTitle()} - Program.cs:40"); 
            Console.WriteLine($"Author: {video.GetAuthor()} - Program.cs:41"); 
            Console.WriteLine($"Length: {video.GetLength()} seconds - Program.cs:42"); 
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()} - Program.cs:43"); 
            Console.WriteLine("Comments: - Program.cs:44");
            

            foreach (Comment comment in video.GetComments())
            
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()} - Program.cs:50");
            }


            Console.WriteLine(); 

        }
    }
}