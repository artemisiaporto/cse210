using System.Reflection.Metadata;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] textSplit = text.Split(" ");
        List<Word> wordsList = new List<Word>();
        foreach (string wordText in textSplit)
        {
            Word word = new Word(wordText);
            wordsList.Add(word);
        }
        _words = wordsList;
    }
    public void HideRandomWords(int numberToHide)
    {
        int number = 0;
        if (IsCompletelyHidden() == false)
        {
            while (number < numberToHide)
            {
                Random randomGenerator = new Random();
                //Stretch Challenge - randomly select from only those words that are not already hidden
                int wordNumber = randomGenerator.Next(0, _words.Count);
                //Check if the _isHidden is false before trying to hide the word
                if (_words[wordNumber].IsHidden() == false)
                {
                    _words[wordNumber].Hide();
                    number += 1;
                }
                //Guarantee that the code still works until all words are hidden
                //even if the number of words is not a multiple of 3
                if (IsCompletelyHidden() == true)
                {
                    number = numberToHide;
                }
            }
        }
    }
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string fullText = $"{referenceText} ";

        foreach (Word word in _words)
        {
            if (word.IsHidden() == true)
            {
                char[] characters = word.GetDisplayText().ToCharArray();
                for (int i = 0; i < characters.Length; i++)
                {
                    characters[i] = '_';
                    fullText += characters[i];
                }
                fullText += " ";
            }
            else
            {
                fullText += word.GetDisplayText()+" ";
            }
        }
        return fullText;
    }
    public bool IsCompletelyHidden()
    {
        bool completelyHidden = false;
        int counter = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == true)
            {
                counter += 1;
            }
        }
        if (counter == _words.Count)
        {
            completelyHidden = true;
        }
        return completelyHidden;
    }
}