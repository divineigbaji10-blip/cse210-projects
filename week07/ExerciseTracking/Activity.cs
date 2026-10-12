public abstract class Activity
{
    private string _date;
    private int _lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    protected int Length
    {
        get { return _lengthInMinutes; }
    }

    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_lengthInMinutes} min): Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}