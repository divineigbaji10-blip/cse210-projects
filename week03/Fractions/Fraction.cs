public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _bottom = 1;
        _top = top;
    }
    public Fraction(int top, int bottom)
    {
        _bottom = bottom;
        _top = top;
    }

    public string GetFractionString()
    {
        return ($"{_top}/{_bottom}");
    }

    public double GetDecimalValue()
    {
        return ((double)_top/_bottom);
    }
}

