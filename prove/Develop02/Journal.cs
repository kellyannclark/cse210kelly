using System;
using System.Collections.Generic;

class Journal
{
    
    public string userInput;
    public string prompt;
    public string date;
    public List<string> entryList = new List<string>();
    public List<string> allInfo = new List<string>();
    public PromptGenerator promptGenerator = new PromptGenerator();


    public void addEntry()
    {
        Console.WriteLine("Enter date:");
        date = Console.ReadLine();
        entryList.Add(date);
        prompt = promptGenerator.getPrompt();
        Console.WriteLine(prompt);
        entryList.Add(prompt);
        userInput = Console.ReadLine();
        entryList.Add(userInput);
    }


    public void display()
    {
        for (int i = 0; i < entryList.Count; i += 3)
        {
            Console.WriteLine("Date: " + entryList[i]);
            Console.WriteLine("Journal Prompt: " + entryList[i + 1]);
            Console.WriteLine("Your writing: " + entryList[i + 2]);
        }
    }

    //public void save(string date, string prompt, string userInput) //create a function to save the file

    //{
        //Console.Write("Enter filename: "); //ask user for filename
        //string fileName = Console.ReadLine(); //read filename and assign it to fileName
        //using (StreamWriter save = new StreamWriter(fileName)) //using StreamWriter create a new entry in fileName
        
        //foreach (string item in allInfo)
        //{
            //save.Write($"{item._date}|{item._prompt}|{item._userInput}");
        //}
   // }
        

    public void load() //create a function to load the file
    {
        string fileName = "journal.txt"; //create a var fileName to hold the file name
        string[] lines = System.IO.File.ReadAllLines("fileName"); //create a var lines to hold each line in an array
        using (StreamReader read = new StreamReader(fileName))
        foreach (string item in lines) //iterates through each line
        {   
            List <string> allInfo = item.Split("|").ToList();

        }
    }
    
}