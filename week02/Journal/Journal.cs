using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    private Random random = new Random();

    public void AddEntry()
    {
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"Prompt: {prompt} ");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        entries.Add(new Entry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now.ToShortDateString()
        });

        Console.WriteLine("Entry added!\n ");
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.\n ");
            return;
        }

        foreach (var entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        foreach (var entry in entries)
        {
            writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
        }
        Console.WriteLine("Journal saved.\n ");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n ");
            return;
        }

        entries.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                entries.Add(new Entry
                {
                    Date = parts[0],
                    Prompt = parts[1],
                    Response = parts[2]
                });
            }
        }

        Console.WriteLine("Journal loaded.\n ");
    }
}
