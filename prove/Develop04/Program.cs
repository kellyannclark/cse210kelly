class Program
{
    static void Main(string[] args)
    {
        string menu_option = "";

        while (menu_option != "4")
        {
            Console.WriteLine("Welcome to your Mindfulness Activites.");
            Console.WriteLine("Here are your menu options: ");
            Console.WriteLine("1. Breathing Activty");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activty");
            Console.WriteLine("4. Quit");

            Console.WriteLine("Please select a choice from the menu: ");
            menu_option = Console.ReadLine();

            if (menu_option == "1")
            {   
                Console.WriteLine("Breathing Activity: This activity will help you relax by walking you through your breathing.");
                Console.WriteLine("Please enter the duration of your activity in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                Breathing breathing1 = new Breathing("Breathing Activity", "This activity will help you relax by walking you through your breathing.", duration);
                breathing1.Start();
                Console.Write($"Well done! \n You have completed {duration} seconds of the Breathing Activity.\n");
            }
            if (menu_option == "2")
            {
                Console.WriteLine("Reflection Activity: This activity will help you reflect on times of strength in your life.");
                Console.WriteLine("Please enter the duration of your activity in seconds: ")
                int duration = int.Parse(Console.ReadLine());
            }
            if (menu_option == "3")
            {
                
            }
        }
    }   
}