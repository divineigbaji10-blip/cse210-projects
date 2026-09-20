using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _words = new List <Word>();
        string[] parts = text.Split(" ");

        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public void DisplayScripture()
    {
        Console.Write(_reference.GetDisplayText() + ' ');
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetDisplayText()} ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords()
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.IsHidden() != true)
            {
                visibleWords.Add(word);
            }
        }
        Random random = new Random();
        for (int i = 0; i < 1; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}