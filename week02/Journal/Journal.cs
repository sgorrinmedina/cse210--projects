using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    private List<string> _prompts;

    public Journal()
    {
        _entries = new List<Entry>();
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What made me smile today?",
            "What challenged me the most today?",
            "What am I most grateful for today?"
        };
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];

            Entry entry = new Entry(date, promptText, entryText);
            _entries.Add(entry);
        }
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        return _prompts[index];
    }
}

