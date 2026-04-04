using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing",
        "This activity will help you relax by guiding your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartMessage();

        int time = 0;
        while (time < _duration)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);

            Console.Write("Breathe out... ");
            ShowCountdown(4);

            time += 8;
        }

        DisplayEndMessage();
    }
}