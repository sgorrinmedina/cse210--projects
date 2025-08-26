using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private Random _random;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();
            foreach (string wordText in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                _words.Add(new Word(wordText));
            }
            _random = new Random();
        }

        public void HideRandomWords(int count)
        {
            List<Word> availableWords = _words.Where(w => !w.IsHidden()).ToList();
            if (availableWords.Count == 0)
            {
                return; // All words are already hidden
            }

            for (int i = 0; i < count; i++)
            {
                int indexToHide = _random.Next(availableWords.Count);
                availableWords[indexToHide].Hide();
                availableWords.RemoveAt(indexToHide);

                if (availableWords.Count == 0)
                {
                    break;
                }
            }
        }

        public string GetDisplayText()
        {
            string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
            return $"{_reference.ToString()} {scriptureText}";
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(w => w.IsHidden());
        }
    }
}






