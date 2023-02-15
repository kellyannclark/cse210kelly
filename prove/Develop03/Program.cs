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

        // Call the GetRandomScripture method to get a random scripture
        Scripture randomScripture = scriptureCollection.GetRandomScripture();

        // Display the reference and text of the random scripture
        Console.WriteLine("Reference: " + randomScripture.Reference);
        Console.WriteLine("First Verse: " + randomScripture.FirstVerse);
        Console.WriteLine("Second Verse: " + randomScripture.SecondVerse);

        // Split the scripture text into an array of words
        string[] words = randomScripture.Text.Split(' ');

        while (words.Length > 0)
        {
            // Prompt the user to continue or quit
            Console.WriteLine("Press any key to remove three words or 'q' to quit.");

            string userInput = Console.ReadLine();

            if (userInput == "q")
            {
                return;
            }

            // Randomly remove three words from the text
            Random random = new Random();
            for (int i = 0; i < 3 && words.Length > 0; i++)
            {
                int indexToRemove = random.Next(0, words.Length);
                words[indexToRemove] = "";
            }

            // Remove the empty strings from the array
            words = words.Where(w => !string.IsNullOrEmpty(w)).ToArray();

            // Print the updated text
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
