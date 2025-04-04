# CHAT BOT
Project Structure
The project consists of three main components:

Response Generator (ResponseGenerator.cs)

Voice Greeting (VoiceGreeting.cs)

Logo Generator (LogoGenerator.cs)

Additionally, the main program (Program.cs) manages the chatbot's lifecycle and interaction.

1. ResponseGenerator.cs
This class handles the chatbot’s responses based on user input. It keeps track of the user’s name and generates specific responses about cybersecurity-related topics such as phishing, malware, firewalls, and more. If the chatbot hasn’t learned the user’s name yet, it prompts for the name.

Key Methods:
GetResponse(string input): Returns a relevant response based on the user's input. It can handle cybersecurity-related topics, greetings, or general responses.

2. VoiceGreeting.cs
This class plays a voice greeting when the chatbot starts. It uses the SoundPlayer class to play a .wav file that contains the greeting message.

Key Methods:
PlayGreeting(): Plays the voice greeting from a specified .wav file.

3. LogoGenerator.cs
This class is responsible for converting an image into ASCII art and displaying it in the console. The image is resized to fit within the console window, and each pixel is mapped to a corresponding ASCII character based on its grayscale value.

Key Methods:
DisplayLogo(): Calls the ConvertToASCII() method and prints the ASCII art of the image to the console.

ConvertToASCII(string imagePath): Converts the given image (located at the specified path) into ASCII art and returns the result.

4. Program.cs
This file contains the Chatbot class, which ties together the ResponseGenerator, VoiceGreeting, and LogoGenerator classes. It manages the main loop of the chatbot where it greets the user, listens for input, and responds accordingly.

Key Methods:
StartChat(): Starts the chatbot interaction, playing the voice greeting, displaying the logo, and continuously listening for user input. It handles conversation until the user types "exit".
