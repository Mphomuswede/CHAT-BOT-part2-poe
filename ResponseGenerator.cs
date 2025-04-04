using System;

public class ResponseGenerator
{
    private string userName;
    private bool hasIntroducedName = false; // Keep track of whether the name has been introduced

    // Method to generate responses based on user input
    public string GetResponse(string input)
    {
        // If the name is not set, ask for the user's name
        if (!hasIntroducedName)
        {
            if (input.Contains("my name is"))
            {
                userName = input.Substring(input.IndexOf("is") + 3).Trim(); // Extract name from input
                hasIntroducedName = true; // Mark that the name has been introduced
                return $"Nice to meet you, {userName}! How may I help you?";
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
        else if (input.Contains("phishing"))
        {
            return "Phishing is a type of cyber attack where attackers try to trick people into revealing sensitive information like passwords or credit card numbers by pretending to be a trustworthy entity. Be cautious of unsolicited emails or messages asking for personal information.";
        }
        else if (input.Contains("malware"))
        {
            return "Malware (short for malicious software) is software designed to harm, exploit, or compromise computers and networks. It includes viruses, worms, and Trojans. Always ensure your antivirus software is updated to defend against malware.";
        }
        else if (input.Contains("ransomware"))
        {
            return "Ransomware is a type of malware that locks or encrypts your data and demands payment (ransom) to release it. Always back up your important files regularly and be cautious about suspicious attachments or links.";
        }
        else if (input.Contains("firewall"))
        {
            return "A firewall is a security system that monitors and controls incoming and outgoing network traffic. It can help block malicious traffic from accessing your system and is an essential part of your overall cybersecurity strategy.";
        }
        else if (input.Contains("password security"))
        {
            return "Password security is vital for protecting your accounts and sensitive information. Use strong, unique passwords for each account, and consider using a password manager to keep track of them.";
        }
        else if (input.Contains("two-factor authentication") || input.Contains("2fa"))
        {
            return "Two-factor authentication (2FA) adds an extra layer of security to your accounts by requiring a second form of verification, such as a code sent to your phone, in addition to your password. Always enable 2FA when possible.";
        }
        else if (input.Contains("social engineering"))
        {
            return "Social engineering is a tactic used by cybercriminals to manipulate individuals into divulging confidential information, often by pretending to be someone you trust. Always verify requests for sensitive information before sharing it.";
        }
        else if (input.Contains("data breach"))
        {
            return "A data breach occurs when sensitive information is accessed or exposed without authorization. It's important to monitor your accounts and change passwords immediately if you suspect a breach has occurred.";
        }
        else if (input.Contains("encryption"))
        {
            return "Encryption is the process of converting data into a code to prevent unauthorized access. It is essential for protecting sensitive information, especially when it’s transmitted over the internet.";
        }

        // Regular responses after the name has been introduced
        if (input.Contains("hello"))
        {
            return $"Hello {userName}! How can I help you today?";
        }
        else if (input.Contains("how are you"))
        {
            return "I'm just a bot, but I'm doing great!";
        }
        else if (input.Contains("your name"))
        {
            return "I'm Chatbot, your friendly AI assistant!";
        }
        else if (input.Contains("bye"))
        {
            return "Goodbye! Hope to chat with you soon!";
        }
        else
        {
            return "I'm not sure I understand. Can you rephrase?";
        }
    }
}
