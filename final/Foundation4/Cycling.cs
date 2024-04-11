public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, int length, float speed) : base(date,length)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed*_length/60;
    }

    public override float GetPace()
    {
        return 60/_speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Ciclying ({_length} min): Distance {GetDistance()} km, Speed: {_speed} kph, Pace: {GetPace()} min per km";
    }
}