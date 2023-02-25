using System;
using System.Collections.Generic;
using System.Threading;

class Reflection : Activity
{
    private List<string> promptList;
    private List<string> reflectionList;
    private List<string> animationStrings;

    public Reflection(string title, string description, int duration) : base(title, description, duration)
    {
        promptList = new List<string>();
        promptList.Add("Think of a time when you stood up for someone.");
        promptList.Add("Think of a time when you did something really difficult.");
        promptList.Add("Think of a time when you helped someone in need.");
        promptList.Add("Think of a time when you did something truly selfless.");

        reflectionList = new List<string>();
        reflectionList.Add("Why was this experience meaningful to you?");
        reflectionList.Add("Have you ever done anything like this before?");
        reflectionList.Add("How did you get started?");
        reflectionList.Add("How did you feel when it was complete?");
        reflectionList.Add("What made this time different?");
        reflectionList.Add("What is your favorite thing about this experience?");

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
    Console.WriteLine("Get ready...");
    for (int i = 5; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(GetDuration());

    Random random = new Random();
    int promptIndex = random.Next(promptList.Count);
    string randomPrompt = promptList[promptIndex];
    Console.WriteLine("\nPrompt: " + randomPrompt);

    Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
    Console.ReadLine();


    Random random1 = new Random();

    int previousIndex = -1; // Initialize previous index to a value that won't be used
while (DateTime.Now < endTime)
{
    int index;
    do {
        index = random1.Next(reflectionList.Count);
    } while (index == previousIndex);
    previousIndex = index;
    string reflection = reflectionList[index];

    // Print the reflection and wait for user input
    Console.WriteLine("\nReflection: " + reflection);
    // Show the animation for a full round
    for (int i = 0; i < animationStrings.Count; i++)
    {
        Console.Write(animationStrings[i]);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }
}

}
}
