// --- EXCEED REQUIREMENTS: Capture the mood ---
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\n--- Journal Menu ---");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Show journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("> ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myJournal.AddEntry();
                    break;
                case "2":
                    myJournal.DisplayAll();
                    break;
                case "3":
                    myJournal.SaveToFile();
                    break;
                case "4":
                    myJournal.LoadFromFile();
                    break;
                case "5":
                    Console.WriteLine("\nThank you for using the journaling program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Please enter a number from 1 to 5.");
                    break;
            }
        }
    }
}