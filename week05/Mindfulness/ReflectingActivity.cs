using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you stood up for someone.",
        "Think of a time you did something difficult.",
        "Think of a time you helped someone."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "How can you apply this again?"
    };

    public ReflectionActivity() : base(
        "Reflection",
        "This activity helps you reflect on your strengths.")
    {
    }

    public void Run()
    {
        DisplayStartMessage();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(3);

        int time = 0;
        while (time < _duration)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(4);
            time += 4;
        }

        DisplayEndMessage();
    }
}