using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project. ");

<<<<<<< HEAD
        Console.Write("What is your first name?  9 - Program.cs:9");
=======
        Console.Write("What is your first name? ");
>>>>>>> 6d8b4a5c094b2b1a5b5e48dd9c0052f1282823c5
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}. ");


    }
}
