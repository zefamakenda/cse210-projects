using System;


public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }


    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }


    public void Display()
    {
        Console.WriteLine($"{Date}  {Prompt}  Program.cs:28 - Entry.cs:21");
        Console.WriteLine(Response);
        Console.WriteLine();
    }

}