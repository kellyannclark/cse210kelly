using System;

class Program
{
    static void Main()
    {
        // Create a new instance of the ScriptureCollection class
        ScriptureCollection scriptureCollection = new ScriptureCollection();

        string user_go = "";

        Console.WriteLine("Welcome to your scripture memorizer!");
        Console.WriteLine("Type 'go' to have the random selector choose either a single scripture or multiple verses.");
        Console.WriteLine("The program will quit when all the words disappear.");

        user_go = Console.ReadLine();

        while (user_go == "go")
        {
            // Call the GetRandomScripture method to get a random scripture
            Scripture randomScripture = scriptureCollection.GetRandomScripture();

            // Display the reference and text of the random scripture
            Console.WriteLine("Reference: " + randomScripture.Reference);
            Console.WriteLine("Text: " + randomScripture.Text);

            // Prompt the user to continue or quit
            Console.WriteLine("Press 'go' to see another random scripture, or any other key to quit.");
            user_go = Console.ReadLine();
        }
    }
}

