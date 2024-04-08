using System.Runtime.InteropServices;
using System.Threading.Channels;

public class GoalManager
{
    protected List<Goal> _goals;
    protected int _score;

    public GoalManager()
    {
        List<Goal> list = new List<Goal>();
        _goals = list;
        _score = 0;
    }
    public void Start()
    {
        int choice;
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine();
                Console.WriteLine("The type of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine();
                Console.Write("Which type of goal would you like to create? ");
                CreateGoal();
            }
            if (choice == 2)
            {
                Console.WriteLine();
                Console.WriteLine("The goals are:");
                int counter = 1;
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"{counter}. {goal.GetDetailsString()}");
                    counter++;
                }
            }
            if (choice == 3)
            {
                SaveGoals();
            }
            if (choice == 4)
            {
                _goals.Clear();
                LoadGoals();
                ListGoalNames();
                ListGoalDetails();
            }
            if (choice == 5)
            {
                RecordEvent();
            }
        } while (choice != 6);
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }
    public List<string> ListGoalNames()
    {
        List<string> listName = new List<string>();
        foreach (Goal goal in _goals)
        {
            listName.Add(goal.GetGoalName());
        }
        return listName;
    }
    public void ListGoalDetails()
    {
        List<string> listDetails = new List<string>();
        foreach (Goal goal in _goals)
        {
            listDetails.Add(goal.GetGoalDetail());
        }
    }
    public void CreateGoal()
    {
        int choice2 = int.Parse(Console.ReadLine());
        if (choice2 == 1)
        {
            Console.WriteLine();
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal sGoal = new SimpleGoal(name, description, points);
           _goals.Add(sGoal);
        }
        if (choice2 == 2)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            EternalGoal eGoal = new EternalGoal(name, description, points);
            _goals.Add(eGoal);
        }
        if (choice2 == 3)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal cGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(cGoal);
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine();
        List<string> listName = ListGoalNames();        
        Console.WriteLine("The goals are:");
        int counter2 = 1;
        foreach (string name in listName)
        {
            Console.WriteLine($"{counter2}. {name}");
            counter2++;
        }
        Console.WriteLine();
        Console.Write("Which goal did you accomplish? ");
        int accomplished = int.Parse(Console.ReadLine());
        Goal completedGoal = _goals[accomplished-1];
        if (completedGoal is ChecklistGoal)
        {
            ChecklistGoal checklistGoal = (ChecklistGoal)completedGoal;
            if (checklistGoal.IsComplete())
            {
                Console.WriteLine("This goal is already completed, create a new one or complete another.");
            }
            else
            {
                _score += checklistGoal.RecordEvent();
            }
        }
        else if (completedGoal is SimpleGoal)
        {
            if (completedGoal.IsComplete())
            {
                Console.WriteLine("This goal is already completed, create a new one or complete another.");
            }
            else
            {
                _score += completedGoal.RecordEvent();
            }
        }
        else
        {
            _score += completedGoal.RecordEvent();
        }
        
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        
        string[] lines = File.ReadAllLines(filename);
        _score = Int32.Parse(lines[0]);
        
        for (int i=1; i < lines.Count(); i++)
        {
            char[] sep = {':',','};
            string[] parts = lines[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
            string goalType = parts[0];
            if (goalType == "SimpleGoal")
            {
                SimpleGoal sGoal = new SimpleGoal(parts[1],parts[2],Int32.Parse(parts[3]));
                sGoal.SetComplete(parts[4]);
                _goals.Add(sGoal);
            }
            if (goalType == "EternalGoal")
            {
                EternalGoal eGoal = new EternalGoal(parts[1],parts[2],Int32.Parse(parts[3]));
                _goals.Add(eGoal);
            }
            if (goalType == "ChecklistGoal")
            {
                ChecklistGoal cGoal = new ChecklistGoal(parts[1],parts[2],Int32.Parse(parts[3]),Int32.Parse(parts[4]),Int32.Parse(parts[5]));
                cGoal.SetAmountCompleted(Int32.Parse(parts[6]));
                _goals.Add(cGoal);
            }
        }
    }
}