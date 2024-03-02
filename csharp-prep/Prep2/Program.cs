using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        float gradeNum = float.Parse(grade);

        if (gradeNum >= 90)
        {
            Console.WriteLine("Your grade is A. ");
        }
        else if (gradeNum >= 80)
        {
            Console.WriteLine("Your grade is B. ");
        }
        else if (gradeNum >= 70)
        {
            Console.WriteLine("Your grade is C. ");
        }
        else if (gradeNum >= 60)
        {
            Console.WriteLine("Your grade is D. ");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }

        if (gradeNum >= 70)
        {
            Console.WriteLine("Congratulations, you pass the class!");
        }
        else 
        {
            Console.WriteLine("You didn't pass the class, but there is still hope, try again next year!");
        }
    }
}