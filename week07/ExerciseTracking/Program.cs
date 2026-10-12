using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Running running1 = new Running("03 Nov 2022", 30, 4.8);
        Swimming swimming1 = new Swimming("15 Feb 2010", 40, 5);
        Cycling cycling1 = new Cycling("20 May 2015", 30, 20);

        List<Activity> activities = new List<Activity>();
        activities.Add(running1);
        activities.Add(swimming1);
        activities.Add(cycling1);
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}