using System;

static void Main(string[] args)
{
   Console.WriteLine("Hello World! This is the public class Job.");
}

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}


