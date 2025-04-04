using System;
using System.Media;

public class VoiceGreeting
{
    // Method to play a voice greeting
    public void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("C:\\Users\\RC_Student_lab\\source\\repos\\CHAT BOT\\voive greeting.wav");
            player.Play();
            Console.WriteLine("(Playing voice greeting...)");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error playing sound: " + ex.Message);
        }
    }
}
