using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "EEG";
        job1._jobTitle = "Geophysicist";
        job1._startYear = 2022;
        job1._endYear = 2024;

        ///Console.WriteLine(job1._companyName);

        Job job2 = new Job();
        job2._companyName = "Oracle";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2030;
        job2._endYear = 2050;

        ///Console.WriteLine(job2._companyName);

        ///job1.DisplayDetails();
        ///job2.DisplayDetails();

        Resume resume = new Resume();
        resume._personName = "Artemísia Jacob";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        ///Console.WriteLine(resume._jobs[0]._jobTitle);

        resume.DisplayDetails();
    }
}