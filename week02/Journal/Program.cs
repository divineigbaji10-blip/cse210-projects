// I thought about myself using the Journal Program, and then I asked, what if I forgot to save? 
// I made the journal automatically save each new entry immediately after it is written.
// I also created a method called ClearJournal. It clears all entries from the journal and saved file.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Clear Journal");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                List<string> prompts = new List<string>
                {
                    "Who was the most interesting person I interacted with today?",
                    "What was the best part of my day?",
                    "How did I see the hand of the Lord in my life today?",
                    "What was the strongest emotion I felt today?",
                    "If I had one thing I could do over today, what would it be?",
                    "What is one thing I'm grateful for today?", 
                    "What is something I want to accomplish tomorrow?"
                };

                Random random = new Random();
                int randomIndex = random.Next(0, prompts.Count);
                string prompt = prompts[randomIndex];
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Entry entry = new Entry(dateText, prompt, response);
                journal.AddEntry(entry);
                journal.SaveToFile();
                Console.WriteLine("Entry saved automatically!");
            }

            if (choice == "2")
            {
                journal.DisplayAll();
            }

            if (choice == "3")
            {
                journal.LoadFromFile();
            }

            if (choice == "4")
            {
                journal.SaveToFile();
                Console.WriteLine("Journal saved successfully!");
            }

            if (choice == "5")
            {
                Console.WriteLine("Are you sure you want to clear your journal?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.Write(">> ");
                string clearChoice = Console.ReadLine();
                if (clearChoice == "1")
                {
                    journal.ClearJournal();
                    Console.WriteLine("All entries have been cleared!");
                }

                else if (clearChoice == "2")
                {
                    Console.WriteLine("All entries are intact!");
                }

                else
                {
                    Console.WriteLine("Invalid Choice. Your journal was not cleared.");
                }
            }
        }
        Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
    }
}