using System;

class Program

{   
    string menu_option;

    static void Main()
    {
        Console.WriteLine("Welcome to your journal app.");                      
        Console.WriteLine("Please choose from the following menu:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write(">");

        menu_option = Console.ReadLine;
    }
}
