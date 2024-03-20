using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Artemísia Jacob", "Multiplication");
        string assignmentInfo = assignment1.GetSummary();
        Console.WriteLine(assignmentInfo);

        MathAssignment assignment2 = new MathAssignment("Artemísia Jacob", "Multiplication", "7.3", "8-19");
        string mathInfo = assignment2.GetSummary();
        string mathHomework = assignment2.GetHomeworkList();
        Console.WriteLine(mathInfo);
        Console.WriteLine(mathHomework);

        WritingAssignment assignment3 = new WritingAssignment("Artemísia Jacob", "Korean History", "Cheomsongdae Observatory");
        string writingInfo = assignment3.GetSummary();
        string writingHomework = assignment3.GetWritingInformation();
        Console.WriteLine(writingInfo);
        Console.WriteLine(writingHomework);
    }
}