using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creación de Objetos

        // Lista para guardar los videos
        List<Video> videos = new List<Video>();

        // VIDEO 1
        Video video1 = new Video("Learn C# in 10 minutes", "The Code Professor", 600);
        video1.AddComment(new Comment("John", "Great video, very clear."));
        video1.AddComment(new Comment("Mary", "Thanks for the explanation."));
        video1.AddComment(new Comment("Peter", "This helped a lot with my homework."));
        videos.Add(video1);

        // VIDEO 2
        Video video2 = new Video("Best Taco Recipe", "Easy Cooking", 1200);
        video2.AddComment(new Comment("Anna", "They look delicious."));
        video2.AddComment(new Comment("Louis", "What sauce did you use?"));
        video2.AddComment(new Comment("Sophie", "I'm going to try making them today."));
        videos.Add(video2);

        // VIDEO 3
        Video video3 = new Video("World Cup Goals", "Sports TV", 300);
        video3.AddComment(new Comment("Charles", "The second goal was incredible."));
        video3.AddComment(new Comment("Mike", "What an exciting match."));
        video3.AddComment(new Comment("Lucy", "My favorite team won."));
        videos.Add(video3);

        // Uso de Objetos (Iterar y Mostrar)

        foreach (Video v in videos)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Title: {v._title}");
            Console.WriteLine($"Author: {v._author}");
            Console.WriteLine($"Length: {v._length} seconds");

            // Usando el método requerido en el Criterio 4
            Console.WriteLine($"Number of Comments: {v.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            // Iterar sobre los comentarios de ESTE video específico
            foreach (Comment c in v._comments)
            {
                Console.WriteLine($"- {c._name}: {c._text}");
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(); // Espacio en blanco
        }
    }
}