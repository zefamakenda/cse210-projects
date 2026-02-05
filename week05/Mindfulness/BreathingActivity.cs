public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description =
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in... - BreathingActivity.cs:18");
            ShowCountDown(4);

            Console.Write("\nBreathe out... - BreathingActivity.cs:21");
            ShowCountDown(6);

            elapsed += 10;
        }

        DisplayEndingMessage();
    }
}