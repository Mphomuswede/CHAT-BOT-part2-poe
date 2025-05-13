﻿using System;
using System.Drawing;

public class LogoGenerator
{
    // Method to display an ASCII logo (art)
    public void DisplayLogo()
    {
        string asciiArt = ConvertToASCII(@"C:\Users\RC_Student_lab\source\repos\CHAT BOT\images (60).jpeg"); // Correct path to image
        Console.WriteLine(asciiArt);
    }

    // Method to convert an image to ASCII art
    private string ConvertToASCII(string imagePath)
    {
        try
        {
            Bitmap image = new Bitmap(imagePath);
            image = new Bitmap(image, new Size(50, 25)); // Resize for better console fit

            char[] asciiChars = { '@', '#', '8', '&', '%', '$', '*', '+', '=', '-', ':', '.', ' ' };

            string asciiArt = "";
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int grayValue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int index = grayValue * (asciiChars.Length - 1) / 255;
                    asciiArt += asciiChars[index];
                }
                asciiArt += "\n";
            }

            return asciiArt;
        }
        catch (Exception ex)
        {
            return "Error converting image: " + ex.Message;
        }
    }
}
