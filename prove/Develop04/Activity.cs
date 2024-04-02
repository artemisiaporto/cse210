using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
            animation.Add("|");
            animation.Add("/");
            animation.Add("-");
            animation.Add("\\");
            animation.Add("|");
            animation.Add("/");
            animation.Add("-");
            animation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string str = animation[i];
            Console.Write(str);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {
                i=0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
    }
}