using System;

public class Chatbot
{
    private string userName;
    private string userInterest;
    private bool hasIntroducedName = false;
    private bool hasSharedInterest = false;
    private ResponseGenerator responseGenerator = new ResponseGenerator();

    public void StartChat()
    {
        Console.WriteLine("Hello! I am your AI chatbot. Type 'exit' to end the chat.");
        while (true)
        {
            Console.Write("You: ");
            string userInput = Console.ReadLine()?.ToLower();

            if (userInput == "exit")
            {
                Console.WriteLine("Chatbot: Goodbye!");
                break;
            }

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Chatbot: Please say something!");
                continue;
            }

            if (!hasIntroducedName && userInput.Contains("my name is"))
            {
                userName = userInput.Substring(userInput.IndexOf("is") + 3).Trim();
                hasIntroducedName = true;
                Console.WriteLine($"Chatbot: Nice to meet you, {userName}!");
                continue;
            }

            if (!hasSharedInterest && userInput.Contains("i'm interested in"))
            {
                userInterest = userInput.Substring(userInput.IndexOf("in") + 3).Trim();
                hasSharedInterest = true;
                Console.WriteLine($"Chatbot: Got it! I'll remember that you're interested in {userInterest}.");
                continue;
            }

            string response = responseGenerator.GetResponse(userInput);
            if (hasSharedInterest)
            {
                response += $" Since you're interested in {userInterest}, you might want to explore related topics.";
            }
            Console.WriteLine($"Chatbot: {response}");
        }
    }
}
