public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus):base(name,description,points)
    {
        _goalName = name;
        _description = description;
        _points = points;
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override int RecordEvent()
    {
        _amountCompleted += 1;
        if (IsComplete())
        {
            GetDetailsString();
            Console.WriteLine($"Congratulations! You have earned {_points + _bonus}!");
            return _points + _bonus;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points}!");
            return _points;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
    public void AddAmountCompleted()
    {
        _amountCompleted += 1;
    }
    public int GetBonus()
    {
        return _bonus;
    }

    public int GetAmount()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }
    public override string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            return $"[X] {_goalName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_goalName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_goalName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}