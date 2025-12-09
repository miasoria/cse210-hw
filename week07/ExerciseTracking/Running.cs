using System;

public class Running : Activity
{
    private double _distance; // in miles

    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // Speed (mph) = (Distance / Minutes) * 60
        return (_distance / GetLength()) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = Minutes / Distance
        return GetLength() / _distance;
    }
}