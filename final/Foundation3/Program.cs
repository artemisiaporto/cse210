using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lectureEvent = new Lecture("Book Club", "Read and comment about Harry Potter", "04/20/2024", "5 pm", "City's Main Square", "Mrs. Potter", 50);
        //string lStandard = lectureEvent.GetStandardDetails();
        //Console.WriteLine(lStandard);
        //string lFullDetails = lectureEvent.GetFullDetails();
        //Console.WriteLine(lFullDetails);
        //string lShortDescription = lectureEvent.GetShortDescription();
        //Console.WriteLine(lShortDescription);
        Console.WriteLine($"Subject - {lectureEvent.GetShortDescription()}");
        Console.WriteLine();
        Console.WriteLine("Hello, dear reader.");
        Console.WriteLine("We would like to kindly invite you to our Book Club 1st Session.");
        Console.WriteLine("We will hear from Mrs. Potter and talk about the Harry Potter collection of books.");
        Console.WriteLine("Here is the complete information about the event:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();

        Reception receptionEvent = new Reception("New Semester Courses", "Present and describe the new available courses for the students", "04/25/2024", "8 am", "City University", "graduationsecretary@outlook.com", 100);
        //string rStandard = receptionEvent.GetStandardDetails();
        //Console.WriteLine(rStandard);
        //string rFullDetails = receptionEvent.GetFullDetails();
        //Console.WriteLine(rFullDetails);
        //string rShortDescription = receptionEvent.GetShortDescription();
        //Console.WriteLine(rShortDescription);
        Console.WriteLine($"Subject - {receptionEvent.GetShortDescription()}");
        Console.WriteLine();
        Console.WriteLine("Hello, dear student.");
        Console.WriteLine("We would like to kindly invite you to our early semester reception.");
        Console.WriteLine("We will present the new courses and have professors explain more about them.");
        Console.WriteLine("Here is the complete information about the event:");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("Please, make sure to register through the email provided.");
        Console.WriteLine();

        OutdoorGathering outdoorEvent = new OutdoorGathering("Planting The Future", "Plant tree seedlings in the city woods", "04/30/2024", "9 am", "City Woods", "Sunny");
        //string oStandard = outdoorEvent.GetStandardDetails();
        //Console.WriteLine(oStandard);
        //string oFullDetails = outdoorEvent.GetFullDetails();
        //Console.WriteLine(oFullDetails);
        //string oShortDescription = outdoorEvent.GetShortDescription();
        //Console.WriteLine(oShortDescription);
        Console.WriteLine($"Subject - {outdoorEvent.GetShortDescription()}");
        Console.WriteLine();
        Console.WriteLine("Hello, dear neighborhood.");
        Console.WriteLine("We would like to kindly invite you to our 'Planting Event'.");
        Console.WriteLine("We will plant tree seedlings in the city woods and enjoy the time together.");
        Console.WriteLine("Here is the complete information about the event:");
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine("Please, make sure to wear clothes that fit the weather prevision.");
    }
}