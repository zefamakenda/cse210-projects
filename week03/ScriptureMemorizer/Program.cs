using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the ScriptureMemorizer Project. - Program.cs:9");

            // Create a reference
            Reference reference = new Reference("Alma", 36, 3);

            // Create a scripture
            Scripture scripture = new Scripture(
                reference,
                "And now, O my son Helaman, behold, thou art in thy youth, " +
                "and therefore, I beseech of thee that thou wilt hear my words and learn of me; " +
                "for I do know that whosoever shall put their trust in God shall be supported " +
                "in their trials, and their troubles, and their afflictions, and shall be lifted up at the last day"
            );

            bool scriptureFullyHidden = false;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayTextWithReference());

                if (scriptureFullyHidden)
                {
                    Console.WriteLine("\nAll words are hidden! Program ending... - Program.cs:32");
                    Console.ReadLine(); // wait for ONE final Enter
                    break;
                }

                Console.Write("\nPress Enter to continue or type 'quit' to exit: - Program.cs:37");
                string input = Console.ReadLine();

                if (input?.ToLower() == "quit")
                    break;

                scripture.HideRandomWords(3);

                // If it JUST became fully hidden, mark it but do NOT exit yet
                if (scripture.IsCompletelyHidden())
                {
                    scriptureFullyHidden = true;
                }
            }


        }
    }
}