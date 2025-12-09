using System;

public abstract class Activity
{
    // Encapsulation: member variables are private
    private string _date;
    private int _length; // in minutes

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }

    // Polymorphism: Abstract methods to be overridden by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Polymorphism: GetSummary calls the virtual/abstract methods
    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_length} min) - Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}