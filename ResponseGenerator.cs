using System.Collections.Generic;
using System;

public class ResponseGenerator
{
    private Random random = new Random();

    private Dictionary<string, List<string>> randomResponses = new Dictionary<string, List<string>>
    {
        { "phishing", new List<string> {
            "Be cautious of emails asking for personal information.",
            "Verify the sender's email address before clicking links.",
            "Look out for urgent requests that create a sense of urgency."
        }}
    };

    public string GetResponse(string input)
    {
        foreach (var keyword in randomResponses.Keys)
        {
            if (input.Contains(keyword))
            {
                var responses = randomResponses[keyword];
                return responses[random.Next(responses.Count)];
            }
        }
        return "Can you please clarify?";
    }
}
