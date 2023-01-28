using System;
using System.Collections.Generic;

class PromptGenerator
{
    
    int randomNumber;

    public List<string> promptList = new List<string>();
    public Random random = new Random();

    public PromptGenerator()
    {
        promptList.Add("Write a review of the last movie you saw. :  ");
        promptList.Add("Write about something nice a stranger has done for you. :  ");
        promptList.Add("Share your testimony of the gospel of Jesus Christ. :  ");
        promptList.Add("Write about a scripture that means something to you. :  ");
        promptList.Add("Write about a conference talk that has made a difference in your life and why. :  ");
    }

    public string getPrompt()
    {
        randomNumber = random.Next(0, 4);
        return promptList[randomNumber];
    }

}