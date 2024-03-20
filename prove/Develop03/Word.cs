using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

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
        _text = "_____";
        _isHidden = true;
    }

    public void Show()
    {
        GetDisplayText();
    }

    public bool IsHidden()
    {
        bool value = true;
        return value;
    }

    public string GetDisplayText()
    {
        return $"{_text}";
    }
}