public class Running : Activity
{
    private float _distance;

    public Running(string date, int length, float distance) : base(date,length)
    {
        _distance = distance;
    }

    public override float GetSpeed()
    {
        return _distance/_length*60;
    }

    public override float GetPace()
    {
        return _length/_distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_length} min): Distance {_distance} km, Speed: {Math.Round(GetSpeed(),1)} kph, Pace: {GetPace()} min per km";
    }
}