using System;


class Program 

{
    
    static void Main(string[] args) 
    
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project."); 
        List<Goal> goals = new List<Goal>(); 
        int score = 0;
        bool running = true;


        while (running)

        {

            Console.WriteLine("\nEternal Quest Menu ");
            Console.WriteLine("1. Create New Goal ");
            Console.WriteLine("2. List Goals ");
            Console.WriteLine("3. Record Event ");
            Console.WriteLine("4. Show Score ");
            Console.WriteLine("5. Save Goals ");
            Console.WriteLine("6. Load Goals ");
            Console.WriteLine("7. Quit ");


            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)

            {
                case "1":
                    CreateGoal(goals);
                    break;


                case "2":
                    ListGoals(goals);
                    break;


                case "3":
                    score += RecordGoal(goals);
                    break;


                case "4":
                    Console.WriteLine($"Your score is: {score} ");
                    break;

                case "5":
                    SaveGoals(goals, score);
                    break;


                case "6":
                    LoadGoals(goals, out score);
                    break;


                case "7":
                    running = false;

                    break;

            }

        }

        // Exceeding requirements:
        // The program uses polymorphism to handle all goal types through a single Goal list.
        
    }

    static void CreateGoal(List<Goal> goals)

    {
        
        Console.WriteLine("\nThe types of Goals are: ");  
        Console.WriteLine("1. Simple Goal "); 
        Console.WriteLine("2. Eternal Goal ");
        Console.WriteLine("3. Checklist Goal "); 
        

        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();
        

        Console.Write("Name: ");
        string name = Console.ReadLine(); 

        Console.Write("Description: ");
        string description = Console.ReadLine(); 
        

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());


        if (type == "1")

        {
            goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")

        {

            goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")

        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());


            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());


            goals.Add(new ChecklistGoal(name, description, points, target, bonus));

        }
        
    }

    static void ListGoals(List<Goal> goals) 
    
    {
        Console.WriteLine(); 
        for (int i = 0; i < goals.Count; i++)

        {
            
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()} "); 
        }
    } 

    static int RecordGoal(List<Goal> goals)
    {
        
        ListGoals(goals); 

        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        
        

        int earned = goals[index].RecordEvent();
        Console.WriteLine($"You earned {earned} points! ");


        return earned;
        
    }

    static void SaveGoals(List<Goal> goals, int score)

    { 
        
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();


        using (StreamWriter output = new StreamWriter(filename))

        {
            output.WriteLine(score); 

            foreach (Goal goal in goals)

            {
                
                output.WriteLine(goal.GetStringRepresentation());
            } 
        }
    } 

    static void LoadGoals(List<Goal> goals, out int score) 
    
    {
        Console.Write("Enter filename: "); 

        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);
        
        goals.Clear();

        score = int.Parse(lines[0]);


        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");



            if (type == "SimpleGoal")

            {

                var goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                if (bool.Parse(data[3])) goal.RecordEvent();
                goals.Add(goal);

            }

            else if (type == "EternalGoal")

            {

                goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));

            }

            else if (type == "ChecklistGoal")

            {
                var goal = new ChecklistGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    int.Parse(data[4]),
                    int.Parse(data[3])

                );


                int completed = int.Parse(data[5]);

                for (int c = 0; c < completed; c++)

                    goal.RecordEvent();

                goals.Add(goal);
            }

        }
        
    }
}
