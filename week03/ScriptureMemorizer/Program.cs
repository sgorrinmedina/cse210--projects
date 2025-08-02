using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exceeding requirements: Implement a library of scriptures
            // This enhancement allows the program to work with multiple scriptures
            // and randomly selects one for the user to memorize
            List<Scripture> scriptures = new List<Scripture>
            {
                new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
                new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
                new Scripture(new Reference("Mosiah", 2, 41), "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.")
            };

            Random random = new Random();
            Scripture currentScripture = scriptures[random.Next(scriptures.Count)];

            while (!currentScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to continue or type \'quit\' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                // Hide 3 words at a time for better user experience
                currentScripture.HideRandomWords(3);
            }

            // Show final state with all words hidden
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine("\nAll words are hidden. Program ending.");
        }
    }
}







