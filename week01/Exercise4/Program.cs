using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        
        List<int> numbers = new List<int>();
        int number = -1; 

        Console.WriteLine("Introduce a list of numbers, enter 0 to exit.");

        do
        {
            Console.Write("Introduce a number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0) 
            {
                numbers.Add(number);
            }

        } while (number != 0);
        
        int sum = numbers.Sum(); 
        Console.WriteLine($"The sum is: {sum}");


        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count; 
            Console.WriteLine($"The average is: {average}");
        }
        else
        {
            Console.WriteLine("No numbers were introduced.");
        }


        if (numbers.Count > 0)
        {
            int maxNumber = numbers.Max(); 
            Console.WriteLine($"The biggest number is: {maxNumber}");
        }
        else
        {
            Console.WriteLine("No numbers were introduced");
        }

    }
}