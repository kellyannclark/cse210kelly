using System;
using System.Collections.Generic;
using System.Threading;

class Breathing : Activity
{
    private List<string> animationStrings;

    public Breathing(string title, string description, int duration) : base(title, description, duration)
    {
        animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
    }

    public void Start()
    {
        Console.WriteLine($"{GetTitle()}: {GetDescription()}");
        Console.WriteLine("Get ready...");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in...");

            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write("Breath out...");

            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}
