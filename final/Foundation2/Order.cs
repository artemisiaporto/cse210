public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public List<string> GetPackingLabel()
    {
        List<string> label = new List<string>();
        foreach(Product product in _products)
        {
            label.Add(product.GetInfo());
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetInfo();
    }

    public double GetTotalPrice()
    {
        double totalPriceProducts = 0;
        foreach (Product product in _products)
        {
            totalPriceProducts += product.GetTotalCost();
        }
        double totalPrice;
        if (_customer.GetCountry() == true)
        {
            int shippingCost = 5;
            totalPrice = totalPriceProducts + shippingCost*_products.Count();
        }
        else
        {
            int shippingCost = 35;
            totalPrice = totalPriceProducts + shippingCost*_products.Count();
        }
        return totalPrice;
    }
}