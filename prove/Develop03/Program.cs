using System;

class Program
{
    static void Main(string[] args)
    {   
        //Reference reference = new Reference("Proverbs",3,5);
        //Scripture scripture = new Scripture(reference,"Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
        
        Reference reference = new Reference("Proverbs",3,5,6);
        Scripture scripture = new Scripture(reference,"Trust and in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        
        string scriptureText = scripture.GetDisplayText();
        bool completed;
        string userAnswer;

        do {
            Console.Clear();
            completed = scripture.IsCompletelyHidden();

            Console.WriteLine(scriptureText);
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            userAnswer = Console.ReadLine();
            scripture.HideRandomWords(3);
            scriptureText = scripture.GetDisplayText();

        } while (userAnswer != "quit" && completed != true);
    }
}