using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project. - Program.cs:7");

        Console.Write("What is your grade percentage? - Program.cs:9");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "F")
        {
            if (percent % 10 >= 7 && letter != "A")
            {
                sign = "+";
            }
            else if (percent % 10 < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign} - Program.cs:49");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course! - Program.cs:53");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass. Better luck next time! - Program.cs:57");
        }
    }
}