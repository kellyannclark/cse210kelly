using System;
using System.Collections.Generic;
using System.Threading;

class Listing : Activity
{
    private List<string> promptList;
    private List<string> responseList = new List<string>();

    public Listing(string title, string description, int duration)
    : base(title, description, duration)
    {
        promptList = new List<string>();
        promptList.Add("Who are people that you appreciate?");
        promptList.Add("What are personal strengths of yours?");
        promptList.Add("Who are people that you have helped this week?");
        promptList.Add("When have you felt the Holy Ghost this month?");
        promptList.Add("Who are some of your personal heroes?");
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
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nList as many responses as you can to the following prompt. When done hit enter twice:");

            int promptIndex = random.Next(promptList.Count);
            string randomPrompt = promptList[promptIndex];
            Console.WriteLine("\nPrompt: " + randomPrompt);

            Console.WriteLine("You may begin in ..");

            for (int i = 3; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            List<string> tempResponseList = new List<string>();
            bool isDone = false;
            while (!isDone)
            {
                string response = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(response))
                {
                    isDone = true;
                }
                else
                {
                    tempResponseList.Add(response);
                }
            }

responseList.AddRange(tempResponseList);

Console.WriteLine("Responses saved.");

            responseList.AddRange(tempResponseList);

            Console.WriteLine("Do you want to display the response list? (Y/N)");
            string displayOption = Console.ReadLine();
            if (displayOption.ToUpper() == "Y")
            {
                Console.WriteLine("\nResponses:");
                foreach (string response in responseList)
                {
                    Console.WriteLine("- " + response);
                }
            }
        }
    }
}