using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();
        Running running = new Running("10 Apr 2024", 50, 8);
        activitiesList.Add(running);
        Cycling cycling = new Cycling("12 Apr 2024", 120, 15);
        activitiesList.Add(cycling);
        Swimming swimming = new Swimming("14 Apr 2024", 30, 40);
        activitiesList.Add(swimming);

        Console.Clear();
        Console.WriteLine("The activities information are:");
        Console.WriteLine();
        foreach(Activity activity in activitiesList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}