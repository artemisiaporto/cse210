using System.Reflection.Metadata;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] textSplit = text.Split();
        foreach (string wordText in textSplit)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide)
    {

    }
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string fullText = $"{referenceText} ";

        foreach (Word word in _words)
        {
            fullText += (" "+word.GetDisplayText());
        }
        return fullText;
    }
    public bool IsCompletelyHidden()
    {
        bool value = true;
        return value;
    }
}