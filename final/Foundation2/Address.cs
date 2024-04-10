using System.Security.Authentication;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool GetCountry()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        //Example: 123 Street, City, State Abbreviation, Country
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}