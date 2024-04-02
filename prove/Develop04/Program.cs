using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Clear();
                BreathingActivity act1 = new BreathingActivity();
                act1.DisplayStartingMessage();
                act1.Run();
                act1.DisplayEndingMessage();
            }
            if (choice == 2)
            {
                Console.Clear();
                ReflectingActivity act2 = new ReflectingActivity();
                act2.DisplayStartingMessage();
                act2.Run();
                act2.DisplayEndingMessage();
            }
            if (choice == 3)
            {
                Console.Clear();
                ListingActivity act3 = new ListingActivity();
                act3.DisplayStartingMessage();
                act3.Run();
                act3.DisplayEndingMessage();
            }
        } while (choice != 4);
    }
}