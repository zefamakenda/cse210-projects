using System;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }  // storing as string for simplicity

    public void Display()
    {
        Console.WriteLine($"{Date}  {Prompt} - Entry.cs:11");
        Console.WriteLine(Response);
        Console.WriteLine();
    }
}