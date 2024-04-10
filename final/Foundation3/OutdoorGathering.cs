public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }
    public string GetFullDetails()
    {
        return GetStandardDetails() + $" | Weather: {_weather}";
    }

    public string GetShortDescription()
    {
        return $"Event: Outdoor Gathering | Title: {_title} | Date: {_date}";
    }
}