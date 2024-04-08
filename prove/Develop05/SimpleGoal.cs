public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points):base(name,description,points)
    {
        _goalName = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points}!");
        GetDetailsString();
        _isComplete = true;
        return _points;
    }
    public void SetComplete(string isComplete)
    {
        if (isComplete == "True")
        {
            _isComplete = true;
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_goalName},{_description},{_points},{_isComplete}";
    }
}