// --- EXCEED REQUIREMENTS: Capture the mood ---
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of my day?",
        "How did I see the Lord's hand in my life today?",
        "What was the strongest emotion I felt today?",
        "If I could do one thing again today, what would it be?",
        "What is one thing you are grateful for today?",
    };

    public void AddEntry()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("> ");
        string response = Console.ReadLine();
        Console.WriteLine("How do you feel today? (e.g., Happy, Tired, Calm):");
        Console.Write("Mood> ");
        string mood = Console.ReadLine();

        string dateText = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry
        {
            _date = dateText,
            _prompt = prompt,
            _response = response,
            _mood = mood
        };

        _entries.Add(newEntry);
        Console.WriteLine("Saved entry.");
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nThe journal is empty. Write an entry first!");
            return;
        }

        Console.WriteLine("\n--- FULL DIARY ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("---------------");
    }

    public void SaveToFile()
    {
        Console.WriteLine("Enter the name of the file to save (e.g., my_diary.txt): ");
        string filename = Console.ReadLine();

        string separator = "~|~";

        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}{separator}{entry._prompt}{separator}{entry._response}{separator}{entry._mood}");
                }
            }
            Console.WriteLine($"Journal successfully saved to '{filename}'");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nERROR: An error occurred while saving the file: {ex.Message}");
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("Enter the file name to upload:");
        string filename = Console.ReadLine();

        string separator = "~|~";

        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { separator }, StringSplitOptions.None);

                if (parts.Length == 4)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _prompt = parts[1],
                        _response = parts[2],
                        _mood = parts[3],
                    };
                    _entries.Add(entry);
                }
                else if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _prompt = parts[1],
                        _response = parts[2],
                        _mood = "N/A",
                    };
                    _entries.Add(entry);
                }
            }
            Console.WriteLine($"Journal successfully loaded from '{filename}'.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"\nERROR: The file '{filename}' was not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nAn error occurred while loading the file: {ex.Message}");
        }
    }
}