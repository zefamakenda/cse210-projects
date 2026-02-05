using System;
using System.Threading; 


public class Activity
{
    
    protected string _name; 
    protected string _description;
    protected int _duration;


    public Activity()

    {
        _name = "";
        _description = "";
        _duration = 0;
    }
    

    public void DisplayStartingMessage()
    {
        
        Console.Clear(); 
        Console.WriteLine($"Welcome to the {_name} Activity.\n - Activity.cs:26"); 
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? - Activity.cs:28");  
        _duration = int.Parse(Console.ReadLine());  

        Console.WriteLine("\nGet ready... - Activity.cs:31");
        ShowSpinner(5);  
        
    }

    public void DisplayEndingMessage()
    {
        
        Console.WriteLine("\nWell done! - Activity.cs:39"); 
        ShowSpinner(2);  
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity. - Activity.cs:41");
        ShowSpinner(3); 
        
    }

    public void ShowSpinner(int seconds)
    {
        
        string[] spinner = { "|", "/", "-", "\\" };  
        int index = 0;  
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {

            Console.Write(spinner[index]);
            Thread.Sleep(500);
            string spar = "\b";
            Console.Write(spar);
            index = (index + 1) % spinner.Length;

        }
        
    }

    public void ShowCountDown(int seconds)

    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            string dela = "\b \b";
            Console.Write(dela);


        }
    }
    
}