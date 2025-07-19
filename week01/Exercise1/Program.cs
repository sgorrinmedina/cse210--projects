using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.")

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        string letter = "";

        if (number >= 90)
        {
          letter = "A"; 
        }
        else if (number >= 80)
        {
          letter = "B"; 
        }
        else if (number >= 70)
        {
          letter = "C"; 
        }
        else if (number >= 60)
        {
          letter = "D"; 
        }
        else
        {
          letter = "F"; 
        }


        Console.WriteLine($"Your grade is: {letter}");


        if (number >= 70) 
        {
          Console.WriteLine("Congratulations, you passed this course!");
        }
        else 
        {
          Console.WriteLine("Unfortunately, you did not pass this course. Better luck next time.");
        }

        
    }
}