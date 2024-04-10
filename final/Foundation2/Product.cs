public class Product
{
    private string _productName;
    private int _ID;
    private double _price;
    private int _quantity;

    public Product(string name, int ID, double price, int quantity)
    {
        _productName = name;
        _ID = ID;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price*_quantity;
    }

    public string GetInfo()
    {
        return $"Name: {_productName}, ID: {_ID}.";
    }
}