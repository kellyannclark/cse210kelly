using System;

class Program
{   
    
    
    static void Main()
    {   

        string menu_option = "";
        Journal journal = new Journal();
        ScriptureGenerator scriptures = new ScriptureGenerator();
        

            Console.WriteLine("Welcome to your journal app.");                      
            Console.WriteLine("Please choose from the following menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Daily Scripture");
            Console.WriteLine("6. Quit");
            Console.Write(">");

            menu_option = Console.ReadLine();

        while (menu_option != "6") 
        {

            if (menu_option == "1")
            {
                journal.addEntry();
            }
            else if (menu_option == "2")
            {
                journal.display();
            }
            else if (menu_option == "3")
            {
                journal.load();
            }
            else if (menu_option == "4")
            {
                journal.save(journal.date, journal.prompt, journal.userInput);
            }
            else if (menu_option == "5")
            {
                string scripture = scriptures.getScrip();
                Console.WriteLine(scripture);
            }
            Console.WriteLine("Please choose from the following menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Daily Scripture");
            Console.WriteLine("6. Quit");
            Console.Write(">");

            menu_option = Console.ReadLine();

        }
        
    }
}
