using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al juego Adivina Mi Número!");
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); 

        int numberGuess = 0; 
        int guessCount = 0; 

        do
        {
            guessCount++; 

            Console.Write("¿What is your number? ");
            string userInput = Console.ReadLine();
            numberGuess = int.Parse(userInput); 

            if (numberGuess > magicNumber)
            {
                Console.WriteLine("¡Lower!");
            }
            else if (numberGuess < magicNumber)
            {
                Console.WriteLine("¡Higher!");
            }

        } while (numberGuess != magicNumber); 

        Console.WriteLine("¡You guessed it!");
        Console.WriteLine($"It took you {guessCount} attempts."); 
    }
}