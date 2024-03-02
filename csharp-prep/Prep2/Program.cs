using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        float gradeNum = float.Parse(grade);
        string letter = "";

        if (gradeNum >= 90)
        {
            letter = "A";
        }
        else if (gradeNum >= 80)
        {
            letter = "B";
        }
        else if (gradeNum >= 70)
        {
            letter = "C";
        }
        else if (gradeNum >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (gradeNum >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else 
        {
            Console.WriteLine("You didn't pass the class, but there is still hope! Try again next year.");
        }
    }
}