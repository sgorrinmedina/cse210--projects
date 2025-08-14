using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear(); 
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    return; 
                default:
                    Console.WriteLine("Invalid choice. Please select a number from 1 to 4.");
                    Thread.Sleep(2000); 
                    break;
            }
        }
    }
}

