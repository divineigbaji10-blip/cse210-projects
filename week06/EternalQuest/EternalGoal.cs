public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{ShortName},{Description},{Points}";
    }
}