using System;

class Program
{
    static void Main(string[] args)
    {   
        //To exceed the requirements I implemented a code to randomly select from only those words that are not already
        //hidden and Guarantee that the code still works until all words are hidden even if the number of words is not
        //a multiple of 3.
        //I used the resource about characters on the site https://www.geeksforgeeks.org/different-methods-to-read-a-character-in-c-sharp/?ref=gcse.
        //Reference reference = new Reference("Proverbs",3,5);
        //Scripture scripture = new Scripture(reference,"Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
        
        Reference reference = new Reference("Proverbs",3,5,6);
        Scripture scripture = new Scripture(reference,"Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        
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