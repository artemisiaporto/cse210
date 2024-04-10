using System.ComponentModel.DataAnnotations;

public class Reception : Event
{
    private string _email;
    private int _capacity;

    public Reception(string title, string description, string date, string time, string address, string email, int capacity) : base(title, description, date, time, address)
    {
        _email = email;
        _capacity = capacity;
    }
    public string GetFullDetails()
    {        
        return GetStandardDetails() + $" | Registered email: {_email} | Capacity: {_capacity}";
    }

    public string GetShortDescription()
    {
        return $"Event: Reception | Title: {_title} | Date: {_date}";
    }
}