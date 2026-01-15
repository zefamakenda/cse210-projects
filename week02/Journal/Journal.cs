using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;
    private string[] prompts;

    public Journal()
    {
        entries = new List<Entry>();
        prompts = new string[]
        {
            "Who did I meet or talk to today that stood out the most?",
            "What moment today brought me the most joy or satisfaction?",
            "In what ways did I notice the Lord’s influence in my life today?",
            "What emotion affected me the most throughout the day?",
            "If I could relive one moment from today, what would I change?",
            "What new knowledge or insight did I gain today?",
        }; 

    }


    public void AddEntry()
    {
        string prompt = GetRandomPrompt();
        string response = GetResponse(prompt);
        string date = GetCurrentDate();
        Entry entry = CreateEntry(prompt, response, date);
        entries.Add(entry);
    }


    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(0, prompts.Length)];
    }


    private string GetResponse(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }


    private string GetCurrentDate()
    {
        return DateTime.Now.ToShortDateString();
    }


    private Entry CreateEntry(string prompt, string response, string date)
    {
        return new Entry(prompt, response, date);
    }


    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }


    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }


    public void LoadFromFile(string filename)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = CreateEntry(parts[1], parts[2], parts[0]);
                entries.Add(entry);
            }
        }
    }

}
