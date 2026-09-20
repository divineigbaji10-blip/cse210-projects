//For this assignment I imagined using it myself and if I had to click enter and watch the program not hide anything,
//is kind of frustrating, it would be better if each click removed one word without trying to hide words that are already hidden.
//So, I made the program hide just one word, it doesn't have to randomly pick words that are already hidden, it picks words that
//are not hidden and hide them. 

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding.");
        
        Console.Clear();
        while (scripture.AllWordsHidden() != true)
        {
            scripture.DisplayScripture();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                return;
            }
            Console.Clear();
            scripture.HideRandomWords();
        }
        Console.Clear();
        scripture.DisplayScripture();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
    }
}