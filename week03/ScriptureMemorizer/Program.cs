using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Crear la referencia y la escritura
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        // 2. Bucle principal
        while (true)
        {
            Console.Clear();

            // Mostrar la escritura (con palabras ocultas si aplica)
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Verificar si ya se ocultó todo para terminar automáticamente
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText()); // Mostrar estado final
                Console.WriteLine("\nAll words are hidden. Good job!");
                break;
            }

            // Ocultar 3 palabras aleatorias cada vez que se presiona Enter
            scripture.HideRandomWords(3);
        }
    }
}