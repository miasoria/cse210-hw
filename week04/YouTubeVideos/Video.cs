using System;
using System.Collections.Generic; // Necesario para usar Listas

public class Video
{
    // Variables miembro
    public string _title;
    public string _author;
    public int _length; // En segundos

    // Composición: La clase Video guarda una lista de objetos Comment
    public List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Método para agregar un comentario a la lista (Abstracción)
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    // Método que retorna el número de comentarios
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}