public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>();
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        List<string> listAnswer = GetListFromUser();
        Console.WriteLine($"You listed {listAnswer.Count} items!");
        Console.WriteLine();
    }

    public string GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        string prompt = "";

        Random randomGenerator = new Random();
        int promptNumber = randomGenerator.Next(1, 5);

        if (promptNumber == 1)
        {
            prompt = _prompts[0];
        }
        else if (promptNumber == 2)
        {
            prompt = _prompts[1];
        }
        else if (promptNumber == 3)
        {
            prompt = _prompts[2];            
        }
        else if (promptNumber == 4)
        {
            prompt = _prompts[3];            
        }
        else if (promptNumber == 5)
        {
            prompt = _prompts[4];            
        }
        return prompt;
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("-> ");
            string answer = Console.ReadLine();
            list.Add(answer);
        }
        return list;
    }
}