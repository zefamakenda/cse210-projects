using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project. - Program.cs:7");

        Random randomGenerator = new Random();
        bool playAgain = true;

        while (playAgain)
        {
         
            int magicNumber = randomGenerator.Next(1, 101);

            int guess;
            int guessCount = 0;

            do
            {
                Console.Write("What is your guess? - Program.cs:22");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    guessCount++;

                    if (magicNumber > guess)
                    {
                        Console.WriteLine("Higher! - Program.cs:29");
                    }
                    else if (magicNumber < guess)
                    {
                        Console.WriteLine("Lower! - Program.cs:33");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it in {guessCount} attempts! - Program.cs:37");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again! - Program.cs:42");
                }
            } while (guess != magicNumber);

            Console.Write("Do you want to play again? (yes/no) - Program.cs:46");
            string response = Console.ReadLine().ToLower().Trim();
            playAgain = response == "yes";
        }

        Console.WriteLine("Thanks for playing! - Program.cs:51");
    }
}
