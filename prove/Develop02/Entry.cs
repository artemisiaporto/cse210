public class Entry
{
    public string _date;
    public string _prompt;
    public string _userAnswer;

    public void Display ()
    {
        Console.WriteLine($"Date: ({_date}) Prompt - {_prompt} ");
        Console.WriteLine(_userAnswer);
        Console.WriteLine();
    }
}