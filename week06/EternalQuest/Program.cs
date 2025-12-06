using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements:
        // I have added a sophisticated loading system that is robust against 
        // different types of goals and maintains the exact state of Checklist goals,
        // including current progress. The menu system is encapsulated in a 
        // GoalManager class to keep the Main method clean.

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}