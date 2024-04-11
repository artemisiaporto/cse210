public class Activity
{
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual float GetDistance()
    {
        return -1;
    }
    public virtual float GetSpeed()
    {
        return -1;
    }
    public virtual float GetPace()
    {
        return -1;
    }
    public virtual string GetSummary()
    {
        return "";
    }
}