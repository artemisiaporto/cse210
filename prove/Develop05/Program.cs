using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceed Requirements:
        // I implemented a condition to run the RecordEvent,
        // allowing only to complete tasks that are not completed yet.
        // I implemented a code to clear the list when using the LoadGoals method,
        // this way the user will not add goals if they load the file more than one time.

        // To write this program I used features from this two websites:
        // Splitting a string using multiple separators: https://stackoverflow.com/questions/7605785/splitting-a-string-based-on-multiple-char-delimiters
        // Convert an object from a class to another: https://stackoverflow.com/questions/3672742/cast-class-into-another-class-or-convert-class-to-another
        // Clear a list: https://www.geeksforgeeks.org/c-sharp-removing-all-the-elements-from-the-list/?ref=gcse
        // Converting a string to int: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number

        GoalManager journey = new GoalManager();
        journey.Start();
    }
}