// The prompts and questions in Reflecting Activity and Listing Activity never repeat until every one has been used once in a session.
// Each list has an unused list that is refilled when empty, and the activity objects are created once in Main, so the rule lasts the whole session.

using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";
        BreathingActivity breathingActivity1 = new BreathingActivity();
        ReflectingActivity reflectingActivity1 = new ReflectingActivity();
        ListingActivity listingActivity1 = new ListingActivity();
        while(choice != "4")
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                breathingActivity1.Run();
            }
            else if (choice == "2")
            {
                reflectingActivity1.Run();
            }
            else if (choice == "3")
            {
                listingActivity1.Run();
            }
        }
        
    }
}