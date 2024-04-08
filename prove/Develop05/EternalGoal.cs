public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points):base(name,description,points)
    {
        _goalName = name;
        _description = description;
        _points = points;
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points}!");
        return _points;
        // I left it empty because I got confused about this method design.
        // In the design provided the method returns void, but in the text it
        // says that it should "return the point value associated with recording the event".
        // So I choose to make the method return void and return the point value in the GoalManager
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_goalName},{_description},{_points}";
    }
}