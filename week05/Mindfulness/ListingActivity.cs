using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _random = new Random();

    public ListingActivity()
    {
        _name = "Listing";
        _description =
            "This activity will help you reflect on the good things in your life by listing as many things as you can.";

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt: - ListingActivity.cs:29");
        Console.WriteLine($"\n {GetRandomPrompt()} - ListingActivity.cs:30");

        Console.WriteLine("\nYou may begin in: - ListingActivity.cs:32");
        ShowCountDown(5);

        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine($"\nYou listed {_count} items! - ListingActivity.cs:38");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> - ListingActivity.cs:54");
            items.Add(Console.ReadLine());
        }

        return items;
    }
}