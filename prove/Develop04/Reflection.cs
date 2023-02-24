using System;
using System.Collections.Generic;
using System.Threading;

class Reflection : Activity
{
    private List<string> promptList;
    private List<string> reflectionList;

    public Reflection(string title, string description, int duration) : base(title, description, duration)
    {
        promptList = new List<string>();
        promptList.Add("Think of a time when you stood up for someone.")
        promptList.Add("Think of a time when you did something really difficult.")
        promptList.Add("Think of a time when you helped someone in need.")
        promptList.Add("Think of a time when you did something truly selfless.")

        reflectionList = new List<string>();
        reflectionList.Add("Why was this experience meaningful to you?");
        reflectionList.Add("Have you ever done anything like this before?");
        reflectionList.Add("How did you get started?");
        reflectionList.Add("How did you feel when it was complete?");
        reflectionList.Add("What made this time different?");
        reflectionList.Add("What is your favorite thing about this experience?");
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
