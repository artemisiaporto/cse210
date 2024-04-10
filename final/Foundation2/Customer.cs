public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _customerAddress = address;
    }

    public bool GetCountry()
    {
        if (_customerAddress.GetCountry() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetInfo()
    {
        return $"Name: {_customerName}, Address: {_customerAddress.GetFullAddress()}.";
    }
}