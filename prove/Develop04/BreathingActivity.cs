public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        int start = 0;
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine();
        while (start < _duration)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            start += 10;
        }
    }
}