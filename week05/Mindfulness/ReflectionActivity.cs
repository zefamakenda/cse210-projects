using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random = new Random();

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description =
            "This activity will help you reflect on times in your life when you have shown strength and resilience.";

        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you feel when it was complete?",
            "What did you learn about yourself?",
            "How can you apply this experience in the future?",
            "What made this time different?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt: - ReflectionActivity.cs:44");
        Console.WriteLine($"\n {GetRandomPrompt()} - ReflectionActivity.cs:45");
        Console.WriteLine("\nPress Enter when you are ready. - ReflectionActivity.cs:46");
        Console.ReadLine();
    }

    private void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"\n{GetRandomQuestion()} - ReflectionActivity.cs:56");
            ShowSpinner(5);
        }
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[_random.Next(_questions.Count)];
    }
}