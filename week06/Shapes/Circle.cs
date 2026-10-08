public class Circle : Shape
{
    private double _radius;

    public override double GetArea()
    {
        return _radius * 3.14;
    }

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }
}