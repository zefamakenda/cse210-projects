class Program
{
        static void Main(string[] args)
        {
                Console.WriteLine("Hello World! This is the Exercise1 Project. - Program.cs:5");

                Console.Write("What is your first name? - Program.cs:7");
                string firstName = Console.ReadLine();

                Console.Write("What is your last name? - Program.cs:10");
                string lastName = Console.ReadLine();

                Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}. - Program.cs:13");
        }
}