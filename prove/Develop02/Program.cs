using System;
using System.IO.Enumeration;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = -1;
        Journal myJournal = new Journal();
        while (choice != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry myEntry = new Entry();
                PromptGenerator prompt = new PromptGenerator();

                DateTime timeNow = DateTime.Now;
                string dateText = timeNow.ToShortDateString();

                myEntry._date = dateText;
                myEntry._prompt = prompt.GetRandomPrompt();
                Console.WriteLine(myEntry._prompt);
                myEntry._userAnswer = Console.ReadLine();
                myJournal.AddEntry(myEntry);
            }
            if (choice == 2)
            {
                myJournal.DisplayEverything();
            }
            if (choice == 3)
            {
                Console.WriteLine("What is the filename? Example: name.txt");
                string filename = Console.ReadLine();
                myJournal.LoadFile(filename);
            }
            if (choice == 4)
            {
                Console.WriteLine("What is the filename? Example: name.txt");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
        }
    }
}