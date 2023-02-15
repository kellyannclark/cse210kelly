using System;
using System.Collections.Generic;
using System.IO;



public class ScriptureCollection
{
    private List<Scripture> _scriptures = new List<Scripture>();

    public ScriptureCollection()
    {
        // Constructor for the ScriptureCollection class
        // Loads the scripture references and verses from a text file called "scripture.txt"
        // and adds them to the _scriptures list

        // Read the contents of the file into an array of strings
        string[] lines = File.ReadAllLines("scripture.txt");

        // Loop through each line of the file
        foreach (string line in lines)
        {
            // Split the line into two parts: the reference and the text
            string[] parts = line.Split('|');
            string reference = parts[0];
            string firstVerse = parts[1];
            string secondVerse = parts[2];

            // Create a new Scripture object with the reference and text
            Scripture scripture = new Scripture(reference, firstVerse, secondVerse);

            // Add the new Scripture object to the _scriptures list
            _scriptures.Add(scripture);
        }
    }

    public Scripture GetRandomScripture()
    {
        // Method that returns a random scripture from the collection

        // Create a new Random object
        Random rand = new Random();

        // Generate a random index between 0 and the number of scriptures in the collection
        int index = rand.Next(_scriptures.Count);

        // Return the scripture at the randomly generated index
        return _scriptures[index];
    }
}