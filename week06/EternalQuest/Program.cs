using System;


class Program 

{
    
    static void Main(string[] args) 
    
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project. - Program.cs:11"); 
        List<Goal> goals = new List<Goal>(); 
        int score = 0;
        bool running = true;


        while (running)

        {

            Console.WriteLine("\nEternal Quest Menu - Program.cs:21");
            Console.WriteLine("1. Create New Goal - Program.cs:22");
            Console.WriteLine("2. List Goals - Program.cs:23");
            Console.WriteLine("3. Record Event - Program.cs:24");
            Console.WriteLine("4. Show Score - Program.cs:25");
            Console.WriteLine("5. Save Goals - Program.cs:26");
            Console.WriteLine("6. Load Goals - Program.cs:27");
            Console.WriteLine("7. Quit - Program.cs:28");


            Console.Write("Select an option: - Program.cs:31");

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
                    Console.WriteLine($"Your score is: {score} - Program.cs:54");
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
        
        Console.WriteLine("\nThe types of Goals are: - Program.cs:85");  
        Console.WriteLine("1. Simple Goal - Program.cs:86"); 
        Console.WriteLine("2. Eternal Goal - Program.cs:87");
        Console.WriteLine("3. Checklist Goal - Program.cs:88"); 
        

        Console.Write("Which type of goal would you like to create? - Program.cs:91");
        string type = Console.ReadLine();
        

        Console.Write("Name: - Program.cs:95");
        string name = Console.ReadLine(); 

        Console.Write("Description: - Program.cs:98");
        string description = Console.ReadLine(); 
        

        Console.Write("Points: - Program.cs:102");
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
            Console.Write("Target count: - Program.cs:120");
            int target = int.Parse(Console.ReadLine());


            Console.Write("Bonus points: - Program.cs:124");
            int bonus = int.Parse(Console.ReadLine());


            goals.Add(new ChecklistGoal(name, description, points, target, bonus));

        }
        
    }

    static void ListGoals(List<Goal> goals) 
    
    {
        Console.WriteLine(); 
        for (int i = 0; i < goals.Count; i++)

        {
            
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()} - Program.cs:142"); 
        }
    } 

    static int RecordGoal(List<Goal> goals)
    {
        
        ListGoals(goals); 

        Console.Write("Which goal did you accomplish? - Program.cs:151");
        int index = int.Parse(Console.ReadLine()) - 1;
        
        

        int earned = goals[index].RecordEvent();
        Console.WriteLine($"You earned {earned} points! - Program.cs:157");


        return earned;
        
    }

    static void SaveGoals(List<Goal> goals, int score)

    { 
        
        Console.Write("Enter filename: - Program.cs:168");
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
        Console.Write("Enter filename: - Program.cs:189"); 

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