public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, int lengthInMinutes, int numberOfLaps) : base(date, lengthInMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000.0;
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }

    public override double GetSpeed()
    {
        return GetDistance() / Length * 60;
    }
}
