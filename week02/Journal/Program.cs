using System;

    /*
    Exceeding Requirements:
    1. Added more prompts (8 total instead of minimum 5) to provide more variety
    2. Added input validation for menu choices to prevent crashes
    3. Added file existence check when loading to provide better user experience
    4. Added confirmation messages for save/load operations
    5. Enhanced the display format with better spacing and readability
    6. Used a more unique separator (~|~) to reduce chances of conflicts in user text
    */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

       
        Journal theJournal = new Journal();
        
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            string input = Console.ReadLine();
            
            // Input validation
            if (!int.TryParse(input, out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                choice = 0;
                continue;
            }
            
            if (choice == 1)
            {
                // Write a new entry
                string prompt = theJournal.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                
                Entry newEntry = new Entry(dateText, prompt, response);
                theJournal.AddEntry(newEntry);
                
                Console.WriteLine("Entry added successfully!");
            }
            else if (choice == 2)
            {
                // Display the journal
                if (theJournal._entries.Count == 0)
                {
                    Console.WriteLine("No entries found. Please write an entry first.");
                }
                else
                {
                    Console.WriteLine("\nYour Journal Entries:");
                    Console.WriteLine("=====================");
                    theJournal.DisplayAll();
                }
            }
            else if (choice == 3)
            {
                // Load from file
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                
                if (System.IO.File.Exists(filename))
                {
                    theJournal._entries.Clear(); // Clear current entries before loading
                    theJournal.LoadFromFile(filename);
                    Console.WriteLine($"Journal loaded successfully from {filename}!");
                }
                else
                {
                    Console.WriteLine($"File '{filename}' not found. Please check the filename and try again.");
                }
            }
            else if (choice == 4)
            {
                // Save to file
                if (theJournal._entries.Count == 0)
                {
                    Console.WriteLine("No entries to save. Please write an entry first.");
                }
                else
                {
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    theJournal.SaveToFile(filename);
                    Console.WriteLine($"Journal saved successfully to {filename}!");
                }
            }
        }
        
        Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
    }
}

          