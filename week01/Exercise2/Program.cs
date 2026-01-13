using System;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Console.WriteLine("Hello World! This is the Exercise2 Project. ");

        Console.Write("What is your grade percentage? ");
=======
        Console.Write("What is your grade percentage? ");
>>>>>>> 949e6911df252a66f050540cca5d730d51a472f2
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

<<<<<<< HEAD
        Console.WriteLine($"Your letter grade is: {letter}{sign} ");
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course! ");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass. Better luck next time! ");
=======
        Console.WriteLine($"Your letter grade is: {letter}{sign} ");
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course! ");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass. Better luck next time! ");
>>>>>>> 949e6911df252a66f050540cca5d730d51a472f2
        }
    }
}
