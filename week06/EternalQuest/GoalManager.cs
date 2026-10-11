using System.Collections;
using System.Collections.Generic;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void DisplayScore()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points. (Level: {GetLevel()})");
        Console.WriteLine();
    }

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine("The goals are:");
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The type of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        if (choice == "1")
        {
            SimpleGoal simpleGoal1 = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal1);
        }
        else if (choice == "2")
        {
            EternalGoal eternalGoal1 = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal1);
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal1 = new ChecklistGoal(target, bonus, name, description, points);
            _goals.Add(checklistGoal1);
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int goal = int.Parse(Console.ReadLine());
        int position = goal - 1; 
        int pointsEarned = _goals[position].RecordEvent();
        _score += pointsEarned;
        Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("Enter a filename? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();
        for(int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string[] details = parts[1].Split(",");
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal2 = new SimpleGoal(details[0], details[1], int.Parse(details[2]), bool.Parse(details[3]));
                _goals.Add(simpleGoal2);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eternalGoal2 = new EternalGoal(details[0], details[1], int.Parse(details[2]));
                _goals.Add(eternalGoal2);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal2 = new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4]), int.Parse(details[5]));
                _goals.Add(checklistGoal2);
            }
        }
    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            DisplayScore();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoals();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
        }
    }

    private string GetLevel()
    {
        if (_score >= 5000)
        {
            return "Grandmaster";
        }
        else if (_score >= 3000)
        {
            return "Diamond";
        }
        else if (_score >= 1500)
        {
            return "Gold";
        }
        else if (_score >= 500)
        {
            return "Silver";
        }
        else
        {
            return "Bronze";
        }
    }
}