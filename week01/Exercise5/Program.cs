using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        // Llamada al método de bienvenida corregida
        DisplayWelcome();

        // Los métodos ahora devuelven los valores directamente
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        // Pasar el nombre de usuario y el número al cuadrado al método DisplayResult
        DisplayResult(userName, squaredNumber);
    }
    
    // Método para mostrar el mensaje de bienvenida
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!"); // Punto y coma añadido
    }

    // Método para pedir el nombre de usuario y devolverlo
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name; // Tipo de retorno cambiado de void a string
    }
    
    // Método para pedir el número favorito del usuario y devolverlo
    // No necesita un parámetro, ya que obtiene la entrada del usuario
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        // La variable 'number' se declara aquí y se le asigna el valor parseado
        int number = int.Parse(Console.ReadLine());
        return number; // Tipo de retorno cambiado de void a int
    }

    // Método para calcular el cuadrado de un número
    // Usa el parámetro 'numberToSquare' para el cálculo
    static int SquareNumber(int numberToSquare)
    {
        int square = numberToSquare * numberToSquare;
        return square; // Tipo de retorno cambiado de void a int
    }

    // Método para mostrar el resultado final
    // Recibe el nombre y el número al cuadrado como parámetros
    static void DisplayResult(string name, int squaredNumber) // Coma añadida y nombre de parámetro claro
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}"); // Usa el parámetro 'squaredNumber'
    }
}
