// Exceeding Requirements: Instead of working with a single hard-coded scripture, I implemented a library 
// (List<Scripture>) of scriptures. The program randomly selects one scripture 
// from the list each time it runs, allowing the user to memorize different verses.

using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Crear una lista para guardar varias escrituras (La Biblioteca)
        List<Scripture> scriptureLibrary = new List<Scripture>();

        // 2. Agregar escrituras a la biblioteca
        // Ejemplo 1: Juan 3:16
        scriptureLibrary.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
        ));

        // Ejemplo 2: Proverbios 3:5-6 (Rango)
        scriptureLibrary.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
        ));

        // Ejemplo 3: Doctrina y Convenios 6:36
        scriptureLibrary.Add(new Scripture(
            new Reference("D&C", 6, 36),
            "Look unto me in every thought; doubt not, fear not."
        ));

        // Ejemplo 4: 1 Nefi 3:7
        scriptureLibrary.Add(new Scripture(
            new Reference("1 Nephi", 3, 7),
            "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
        ));


        // 3. Seleccionar una escritura al azar
        Random random = new Random();
        int index = random.Next(scriptureLibrary.Count);
        Scripture selectedScripture = scriptureLibrary[index];


        // 4. Bucle principal del programa
        while (true)
        {
            Console.Clear();

            // Mostrar la referencia y el texto (con palabras ocultas si aplica)
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Verificar si la escritura ya está completamente oculta
            if (selectedScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(selectedScripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Good job!");
                break;
            }

            // Ocultar 3 palabras aleatorias
            selectedScripture.HideRandomWords(3);
        }
    }
}