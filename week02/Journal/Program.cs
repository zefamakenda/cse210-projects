using System;
using System.IO;


 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project. - Program.cs:10");

        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Journal Program - Program.cs:16");
            Console.WriteLine("1. Write a new entry - Program.cs:17");
            Console.WriteLine("2. Display journal - Program.cs:18");
            Console.WriteLine("3. Save journal to file - Program.cs:19");
            Console.WriteLine("4. Load journal from file - Program.cs:20");
            Console.WriteLine("5. Quit - Program.cs:21");
            Console.Write("Choose an option: - Program.cs:22");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1": journal.AddEntry(); break;
                case "2": journal.DisplayEntries(); break;
                case "3":
                    Console.Write("Enter filename: - Program.cs:32");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter filename: - Program.cs:36");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                case "5": return;
                default: Console.WriteLine("Invalid option.\n - Program.cs:40"); break;
            }
        }
    }
}