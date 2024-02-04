public class Prompts
{
    static Random rnd = new Random();
    static List<string> prompts = new List<string>
    {"What was the best part about your day?",
    "What did you do to help other people today?",
    "How did you brighten someones day today?",
    "What made your day brighter?",
    "How did you show the love of god today?",
    "What did you eat today?"
    };
    static string prompt;

    static public string RandomPrompt()
    {
        prompt = prompts[rnd.Next(0,6)];
        return prompt;
    }

}