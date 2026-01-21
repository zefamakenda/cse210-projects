using System;

using System.Collections.Generic;

using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project. - Program.cs:11");

        Reference reference = new Reference("Alma", 36, 3);
        Scripture scripture = new Scripture(
            reference,
            "And now, O my son Helaman, behold, thou art in thy youth, and therefore, I beseech of thee that thou wilt hear my words and learn of me; for I do know that whosoever shall put their trust in God shall be supported in their trials, and their troubles, and their afflictions, and shall be lifted up at the last day"
            
        );

        while (true)
        {
            
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            

            Console.Write("\nPress Enter to continue or type 'quit' to exit: - Program.cs:28");
            string input = Console.ReadLine();


            if (input?.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
                break;
        }
    }
}

public class Reference
{

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public Reference(string book, int chapter, int verse)
    {

        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {

        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }


    public string GetDisplayText()
    {

        if (_verse == _endVerse)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";

    }
}


public class Word
{

    private string _text;
    private bool _isHidden;


    public Word(string text)
    {

        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {

        _isHidden = true;

    }

    public bool IsHidden()
    {

        return _isHidden;
    }

    public string GetDisplayText()
    {

        return _isHidden ? new string('_', _text.Length) : _text;
    }
}

public class Scripture
{

    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {

        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {

        for (int i = 0; i < numberToHide; i++)
        {

            var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
            if (visibleWords.Count == 0)
                return;

            visibleWords[_random.Next(visibleWords.Count)].Hide();
        }

    }

    public string GetDisplayText()
    {

        return string.Join(" ", _words.Select(word => word.GetDisplayText()));

    }

    public bool IsCompletelyHidden()
    {
        
        return _words.All(word => word.IsHidden());
    }
}