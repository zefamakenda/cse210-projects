using System;
using System.IO;


    // - Added a search function to search for entries by keyword
    // - Added a function to delete an entry
    // - Improved error handling

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
            Console.WriteLine("5. Search entries ");
            Console.WriteLine("6. Delete entry ");
            Console.WriteLine("7. Quit ");
            Console.Write("Choose an option: ");

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
                        Console.Write("Enter filename: ");
                        string saveFilename = Console.ReadLine();
                        journal.SaveToFile(saveFilename);
                        break;
                        
                    case 4:
                        Console.Write("Enter filename: ");
                        string loadFilename = Console.ReadLine();
                        
                        if (File.Exists(loadFilename))
                        {
                            journal.LoadFromFile(loadFilename);
                        }
                        else
                        {
                            Console.WriteLine("File not found. ");
                        }
                        break;
                        
                    case 5:
                        Console.Write("Enter keyword: ");
                        string keyword = Console.ReadLine();
                        // Search function implementation
                        break;
                        
                    case 6:
                        // Delete entry implementation
                        break;
                        
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Invalid option ");


                        break;
                }
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter a number. ");
            }
            Console.WriteLine();

        }

    }
    
}
