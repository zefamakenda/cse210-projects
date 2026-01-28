using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
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
            // Get all currently visible words ONCE
            List<Word> visibleWords = _words
                .Where(word => !word.IsHidden())
                .ToList();

            // If no visible words remain, stop
            if (visibleWords.Count == 0) return;

            // If remaining visible words are less than or equal to numberToHide, hide all
            if (visibleWords.Count <= numberToHide)
            {
                foreach (var word in visibleWords)
                {
                    word.Hide();
                }
            }
            else
            {
                // Never try to hide more words than exist
                int wordsToHide = Math.Min(numberToHide, visibleWords.Count);
                for (int i = 0; i < wordsToHide; i++)
                {
                    int index = _random.Next(visibleWords.Count);
                    visibleWords[index].Hide();
                    // Remove it so it cannot be picked again
                    visibleWords.RemoveAt(index);
                }
            }
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(word => word.IsHidden());
        }

        public string GetDisplayText()
        {
            return string.Join(" ", _words.Select(word => word.GetDisplayText()));
        }

        public string GetDisplayTextWithReference()
        {
            return $"{_reference.GetDisplayText()}: {GetDisplayText()}";
        }
    }
}