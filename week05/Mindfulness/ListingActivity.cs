public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();
    private List<string> _unusedPrompts = new List<string>();

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts.Add("--- Who are people that you appreciate? ---");
        _prompts.Add("--- What are personal strengths of yours? ---");
        _prompts.Add("--- Who are people that you have helped this week? ---");
        _prompts.Add("--- When have you felt the Holy Ghost this month? ---");
        _prompts.Add("--- Who are some of your personal heroes? ---");
    }

    public void Run()
    {
        _count = 0;
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(Duration);
        while(DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            if (DateTime.Now < futureTime)
            {
                _count++;
            }
        }
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts.AddRange(_prompts);
        }
        Random random = new Random();
        int index = random.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);
        Console.WriteLine(prompt);
    }
}