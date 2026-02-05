using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            string line1 = "Hello World! This is the Mindfulness Project.";
            string line2 = "Mindfulness Program";
            string line3 = "1. Breathing Activity";
            string line4 = "2. Reflecting Activity";
            string line5 = "3. Listing Activity";
            string line6 = "4. Quit";
            string line7 = "\nSelect a choice from the menu: ";
            Console.Clear();

            Console.WriteLine(line1);
            Console.WriteLine();
            Console.WriteLine(line2);
            Console.WriteLine(line3);
            Console.WriteLine(line4);
            Console.WriteLine(line5);
            Console.WriteLine(line6);
            Console.Write(line7);

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectingActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. - Program.cs:46");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
