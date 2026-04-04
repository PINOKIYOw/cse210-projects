using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathings.", duration)
    {

    }

    public void Run()
    {
        Console.Clear();
        DisplayStartMessage();
        Console.Write("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();

        int cycles = Duration / 10;
        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine("");
        }

        DisplayEndingMessage();
    }
}