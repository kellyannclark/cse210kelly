using System;
using System.Collections.Generic;

class ScriptureGenerator
{
    
    int randomNumber;

    public List<string> scriptureList = new List<string>();
    public Random random = new Random();

    public ScriptureGenerator()
    {
        scriptureList.Add("2 Nephi 4:16 Behold, my soul delighteth in the things of the Lord; and my heart pondereth continually upon the things which I have seen and heard.");
        scriptureList.Add("Mosiah 3:23 And now I have spoken the words which the Lord God hath commanded me.");
        scriptureList.Add("Alma 34:18 Yes, cry unto him for mercy; for he is mighty to save.");
        scriptureList.Add("Alma 34:19 Yea, humble yourselves, and continue in prayer unto him.");
        scriptureList.Add("Alma 34:20 Cry unto him when ye are in your fields, yea, over all your flocks.");
    }

    public string getScrip()
    {
        randomNumber = random.Next(0, 4);
        return scriptureList[randomNumber];
    }
}