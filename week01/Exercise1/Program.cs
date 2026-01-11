using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project. - Program.cs:7");

        Console.Write("What is your first name? - Program.cs:9");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? - Program.cs:12");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}. - Program.cs:15");


    }
}