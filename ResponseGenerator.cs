using System;

public class ResponseGenerator
{
    private string userName;

    // Method to generate responses based on user input
    public string GetResponse(string input)
    {
        // If the name is not set, ask for the user's name
        if (string.IsNullOrEmpty(userName))
        {
            if (input.Contains("my name is"))
            {
                userName = input.Substring(input.IndexOf("is") + 3).Trim(); // Extract name from input
                return $"Nice to meet you, {userName}!";
            }
            else
            {
                return "What's your name? Please tell me your name.";
            }
        }

        // Provide cybersecurity-related responses
        if (input.Contains("cybersecurity"))
        {
            return "Cybersecurity is the practice of defending computers, servers, mobile devices, and data from malicious attacks. It's essential to keep software up-to-date, use strong passwords, and be cautious about phishing attempts.";
        }

        // Regular responses
        if (input.Contains("hello"))
            return $"Hello {userName}! How can I help you today?";
        else if (input.Contains("how are you"))
            return "I'm just a bot, but I'm doing great!";
        else if (input.Contains("your name"))
            return "I'm Chatbot, your friendly AI assistant!";
        else if (input.Contains("bye"))
            return "Goodbye! Hope to chat with you soon!";
        else
            return "I'm not sure I understand. Can you rephrase?";
    }
}
