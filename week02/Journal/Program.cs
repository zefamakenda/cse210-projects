using System;
using System.IO;


    // - Added a search function to search for entries by keyword
    // - Added a function to delete an entry
    // - Improved error handling

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project. - Program.cs:13");

        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("Journal Program - Program.cs:18");
            Console.WriteLine("1. Write a new entry - Program.cs:19");
            Console.WriteLine("2. Display journal - Program.cs:20");
            Console.WriteLine("3. Save journal to file - Program.cs:21");
            Console.WriteLine("4. Load journal from file - Program.cs:22");
            Console.WriteLine("5. Search entries - Program.cs:23");
            Console.WriteLine("6. Delete entry - Program.cs:24");
            Console.WriteLine("7. Quit - Program.cs:25");
            Console.Write("Choose an option: - Program.cs:26");

            int option;

            if (int.TryParse(Console.ReadLine(), out option))
            {

                switch (option)
                {
                    case 1:
                        journal.AddEntry();
                        break;
                        
                    case 2:
                        journal.DisplayEntries();
                        break;
                        
                    case 3:
                        Console.Write("Enter filename: - Program.cs:44");
                        string saveFilename = Console.ReadLine();
                        journal.SaveToFile(saveFilename);
                        break;
                        
                    case 4:
                        Console.Write("Enter filename: - Program.cs:50");
                        string loadFilename = Console.ReadLine();
                        
                        if (File.Exists(loadFilename))
                        {
                            journal.LoadFromFile(loadFilename);
                        }
                        else
                        {
                            Console.WriteLine("File not found. - Program.cs:59");
                        }
                        break;
                        
                    case 5:
                        Console.Write("Enter keyword: - Program.cs:64");
                        string keyword = Console.ReadLine();
                        // Search function implementation
                        break;
                        
                    case 6:
                        // Delete entry implementation
                        break;
                        
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Invalid option - Program.cs:76");


                        break;
                }
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter a number. - Program.cs:85");
            }
            Console.WriteLine();

        }

    }
    
}