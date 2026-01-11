using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project. ");

        Random randomGenerator = new Random();
        bool playAgain = true;

        while (playAgain)
        {
         
            int magicNumber = randomGenerator.Next(1, 101);

            int guess;
            int guessCount = 0;

            do
            {
                Console.Write("What is your guess? ");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    guessCount++;

                    if (magicNumber > guess)
                    {
                        Console.WriteLine("Higher! ");
                    }
                    else if (magicNumber < guess)
                    {
                        Console.WriteLine("Lower! ");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it in {guessCount} attempts! ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again! ");
                }
            } while (guess != magicNumber);

            Console.Write("Do you want to play again? (yes/no) ");
            string response = Console.ReadLine().ToLower().Trim();
            playAgain = response == "yes";
        }

        Console.WriteLine("Thanks for playing! ");
    }
}
