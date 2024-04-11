public class Swimming : Activity
{
    private float _numberOfLaps;

    public Swimming(string date, int length, int numberOfLaps) : base(date,length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override float GetDistance()
    {
        return _numberOfLaps*50/1000;
    }

    public override float GetSpeed()
    {
        return GetDistance()/_length*60;
    }

    public override float GetPace()
    {
        return 60/GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_length} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}