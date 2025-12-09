using System;

public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // Distance = (Speed * Minutes) / 60
        return (_speed * GetLength()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        // Pace = 60 / Speed
        return 60 / _speed;
    }
}