using System;
using System.Collections.Generic;

public class Resume
{
    public string _name { get; set; }
    public List<Job> _jobs { get; set; }

    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name} - resume.cs:17");
        Console.WriteLine("Jobs: - resume.cs:18");
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}
