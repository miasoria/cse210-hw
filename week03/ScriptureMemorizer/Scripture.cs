using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Dividimos el texto en palabras y creamos objetos Word
        string[] splitText = text.Split(' ');
        foreach (string part in splitText)
        {
            _words.Add(new Word(part));
        }
    }

    // Oculta una cantidad específica de palabras al azar
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int count = 0;

        // Importante: Evitar bucles infinitos si quedan pocas palabras visibles
        int wordsLeft = 0;
        foreach (Word w in _words)
        {
            if (!w.IsHidden()) wordsLeft++;
        }

        // Si quedan menos palabras de las que queremos ocultar, ocultamos todas las que faltan
        if (wordsLeft <= numberToHide)
        {
            foreach (Word w in _words) w.Hide();
            return;
        }

        // Bucle para ocultar palabras aleatorias
        while (count < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                count++;
            }
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}