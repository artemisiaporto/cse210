using System.Dynamic;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string>();
        _questions = new List<string>();
    }
    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
        Console.Write("Consider the followinh prompt");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        
        if (Console.ReadLine() != "a")
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.Clear();
            int start = 0;
            while (start < _duration)
            {
                Console.Write("-> "+GetRandomQuestion()+" ");
                ShowSpinner(10);
                Console.WriteLine();
                start += 10;
            }
            Console.WriteLine();
        }
        
    }
    public string GetRandomPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _prompts.Add("Think of a time when you remember of Jesus Christ.");

        string prompt = "";

        Random randomGenerator = new Random();
        int promptNumber = randomGenerator.Next(1, 5);

        if (promptNumber == 1)
        {
            prompt = _prompts[0];
        }
        else if (promptNumber == 2)
        {
            prompt = _prompts[1];
        }
        else if (promptNumber == 3)
        {
            prompt = _prompts[2];            
        }
        else if (promptNumber == 4)
        {
            prompt = _prompts[3];            
        }
        else if (promptNumber == 5)
        {
            prompt = _prompts[4];            
        }
        return prompt;
    }
    public string GetRandomQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        string question = "";

        Random randomGenerator = new Random();
        int questionNumber = randomGenerator.Next(1, 9);

        if (questionNumber == 1)
        {
            question = _questions[0];
        }
        else if (questionNumber == 2)
        {
            question = _questions[1];
        }
        else if (questionNumber == 3)
        {
            question = _questions[2];            
        }
        else if (questionNumber == 4)
        {
            question = _questions[3];            
        }
        else if (questionNumber == 5)
        {
            question = _questions[4];            
        }
        else if (questionNumber == 6)
        {
            question = _questions[5];            
        }
        else if (questionNumber == 7)
        {
            question = _questions[6];            
        }
        else if (questionNumber == 8)
        {
            question = _questions[7];            
        }
        else if (questionNumber == 9)
        {
            question = _questions[8];            
        }
        return question;
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }
    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);
    }
}