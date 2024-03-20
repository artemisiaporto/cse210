using System;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference = new Reference("Proverbs",3,5);
        string referenceText = reference.GetDisplayText();
        Console.WriteLine(referenceText);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine bheart; and lean not unto thine cown dunderstanding.");
        string scriptureText = scripture.GetDisplayText();
        Console.WriteLine(scriptureText);
        Console.WriteLine("Scripture that will have its words hiden");
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
    }
}