using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project. ");

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        List<int> numbers = new List<int>();
        int userNumber = -1;

        // Input loop
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();

            if (!int.TryParse(userResponse, out userNumber))
            {
                Console.WriteLine("Invalid input. Please enter an integer. ");
                continue;
            }

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered. ");
            return;
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum} ");

        // Part 2: Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average} ");

        // Part 3: Find the largest number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max} ");

        // Part 4: Find the smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        if (smallestPositive != int.MaxValue)
            Console.WriteLine($"The smallest positive number is: {smallestPositive} ");
        else
            Console.WriteLine("No positive numbers entered. ");

        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
