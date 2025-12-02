using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View total activities completed"); // Opción añadida para Criterio 12
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == "4")
            {
                // Muestra el conteo de uso accediendo a la variable estática.
                Console.Clear();
                Console.WriteLine($"You have completed a total of {Activity._totalActivitiesCompleted} activities so far!");
                Console.Write("Press Enter to return to the menu...");
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}