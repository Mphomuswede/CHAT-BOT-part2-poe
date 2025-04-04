using System;
using CHAT_BOT;

class Chatbot
{
    private ResponseGenerator responseGenerator;
    private VoiceGreeting voiceGreeting;
    private LogoGenerator logoGenerator;

    public Chatbot()
    {
        responseGenerator = new ResponseGenerator();
         new VoiceGreeting() { };
         new LogoGenerator() { };
    }

    public void StartChat()
    {
        voiceGreeting.PlayGreeting(); // Play voice greeting
        logoGenerator.DisplayLogo(); // Display ASCII logo
        Console.ForegroundColor = ConsoleColor.Cyan; // Change text color
        Console.WriteLine("Hello! I am your AI chatbot. Type 'exit' to end the chat.");
        Console.ResetColor();

        while (true)
        {
            Console.Write("You: ");
            string userInput = Console.ReadLine()?.ToLower(); // Get user input

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

            string response = responseGenerator.GetResponse(userInput); // Get response
            Console.WriteLine("Chatbot: " + response);
        }
    }
}

class Program
{
    static void Main()
    {
        Chatbot bot = new Chatbot();
        bot.StartChat();
    }
}
