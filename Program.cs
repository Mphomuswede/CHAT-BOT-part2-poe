using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;

class Chatbot
{
    private string userName;
    private bool hasIntroducedName = false;
    private MLContext mlContext;
    private ITransformer mlModel;
    private PredictionEngine<SentimentData, SentimentPrediction> predEngine;

    private Dictionary<string, string[]> keywordResponses = new Dictionary<string, string[]>
    {
        { "password", new[] { "Use strong, unique passwords for each account.", "Avoid using personal details in your passwords." } },
        { "scam", new[] { "Be cautious of unsolicited messages asking for personal information.", "Verify the source before clicking on links or downloading attachments." } },
        { "privacy", new[] { "Regularly review your privacy settings on social media platforms.", "Be mindful of the information you share online." } }
    };

    public Chatbot()
    {
        mlContext = new MLContext();
        // Load your trained model
        mlModel = mlContext.Model.Load("sentiment_model.zip", out var modelInputSchema);
        predEngine = mlContext.Model.CreatePredictionEngine<SentimentData, SentimentPrediction>(mlModel);
    }

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

            string sentiment = AnalyzeSentiment(userInput);
            string response = GetResponse(userInput);

            Console.WriteLine($"Chatbot: {response} (Sentiment: {sentiment})");
        }
    }

    private string AnalyzeSentiment(string input)
    {
        var result = predEngine.Predict(new SentimentData { SentimentText = input });
        return result.Prediction == 1 ? "Positive" : "Negative";
    }

    private string GetResponse(string input)
    {
        if (!hasIntroducedName)
        {
            if (input.Contains("my name is"))
            {
                userName = input.Substring(input.IndexOf("is") + 3).Trim();
                hasIntroducedName = true;
                return $"Nice to meet you, {userName}!";
            }
            else
            {
                return "What's your name?";
            }
        }

        foreach (var keyword in keywordResponses.Keys)
        {
            if (input.Contains(keyword))
            {
                var responses = keywordResponses[keyword];
                var random = new Random();
                return responses[random.Next(responses.Length)];
            }
        }

        if (input.Contains("hello"))
        {
            return $"Hello {userName}!";
        }
        else if (input.Contains("how are you"))
        {
            return "I'm doing great, thanks!";
        }
        else if (input.Contains("your name"))
        {
            return "I'm Chatbot!";
        }
        else if (input.Contains("bye"))
        {
            return $"Goodbye, {userName}!";
        }
        else
        {
            return "Can you rephrase?";
        }
    }
}
