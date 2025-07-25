using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Create Job instances
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2020;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2020;
        job2._endYear = 2024;

        // Create Resume instance
        Resume resume1 = new Resume();
        resume1._personName = "Allison Rose";

        // Add jobs to resume
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Display the resume
        resume1.Display();
    }
}




        Console.WriteLine("Hello World! This is the Resumes Project.");
