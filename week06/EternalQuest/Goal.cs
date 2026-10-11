public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string checkbox;
        if (IsComplete())
        {
            checkbox = "[X]";     
        }
        else
        {
            checkbox = "[ ]";
        }
        return $"{checkbox} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

    protected string ShortName
    {
        get {return _shortName;}
    }

    protected string Description
    {
        get {return _description;}
    }

    protected int Points
    {
        get {return _points;}
    }
}