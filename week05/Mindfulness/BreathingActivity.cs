public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(Duration);
        while(DateTime.Now < futureTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountDown(5);
            Console.WriteLine();
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}