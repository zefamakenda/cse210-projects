using System;
using System.IO;


 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project. ");

        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Journal Program ");
            Console.WriteLine("1. Write a new entry ");
            Console.WriteLine("2. Display journal ");
            Console.WriteLine("3. Save journal to file ");
            Console.WriteLine("4. Load journal from file ");
            Console.WriteLine("5. Quit ");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1": journal.AddEntry(); break;
                case "2": journal.DisplayEntries(); break;
                case "3":
                    Console.Write("Enter filename: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter filename: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                case "5": return;
                default: Console.WriteLine("Invalid option.\n "); break;
            }
        }
    }
}
