using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {   
    };

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int randomIndex = randomPrompt.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}