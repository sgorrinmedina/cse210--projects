using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!")
        }

        static void PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }
        
        static void PromptUserNumber(int number)
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static void SquareNumber(int squareNumber)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name int number) 
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
}