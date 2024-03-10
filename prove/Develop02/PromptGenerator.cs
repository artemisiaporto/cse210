public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        _prompts.Add("How was your morning today?");
        _prompts.Add("How many fruits did you eat?");
        _prompts.Add("Did you take breaks during work or study sessions, and if so, how do you spend them?");
        _prompts.Add("Did you have a bad moment today?");
        _prompts.Add("Write the first 5 words that came to your mind.");
        _prompts.Add("Tell about a person that made a difference in your day (in good or/and in a bad way).");
        _prompts.Add("What could you do better today to have a better tomorrow?");
        _prompts.Add("Write a list for the next market purchase.");
        _prompts.Add("What was the TV that you most liked to watch today?");

        string prompt = "";

        Random randomGenerator = new Random();
        int promptNumber = randomGenerator.Next(1, 8);

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
        else if (promptNumber == 6)
        {
            prompt = _prompts[5];            
        }
        else if (promptNumber == 7)
        {
            prompt = _prompts[6];            
        }
        else if (promptNumber == 8)
        {
            prompt = _prompts[7];            
        }
        return prompt;
    }
}