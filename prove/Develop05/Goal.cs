public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _points = points;
    }
    public abstract int RecordEvent();
    
    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        bool state;
        state = IsComplete();
        if (state == true)
        {
            return $"[X] {_goalName} ({_description})";
        }
        else
        {
            return $"[ ] {_goalName} ({_description})";
        }
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    public string GetGoalDetail()
    {
        if (IsComplete() == true)
        {
            return $"[X] ({_description})";
        }
        else
        {
            return $"[ ] ({_description})";
        }
    }
    public int GetPoints()
    {
        return _points;
    }
    public abstract string GetStringRepresentation();
}