using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Product> o1Products = new List<Product>();
        Product o1Product1 = new Product("Golden Apple", 159, 2, 50);
        Product o1Product2 = new Product("Red Banana", 357, 4, 60);
        Product o1Product3 = new Product("Kiwi", 654, 6, 40);
        o1Products.Add(o1Product1);
        o1Products.Add(o1Product2);
        o1Products.Add(o1Product3);
        Address c1Address = new Address("123 Blue Street", "Los Angeles", "CA", "USA");
        Customer c1 = new Customer("Anna", c1Address);
        Order order1 = new Order(o1Products, c1);

        Console.WriteLine($"Order 1 - Packing Label:");
        List<string> o1Label = order1.GetPackingLabel();
        foreach (string info in o1Label)
        {
            Console.WriteLine(info);
        }
        Console.WriteLine($"Order 1 - Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        double o1TotalPrice = order1.GetTotalPrice();
        Console.WriteLine($"Order 1 - Total Price: ${o1TotalPrice}.");
        
        Console.WriteLine();
        List<Product> o2Products = new List<Product>();
        Product o2Product1 = new Product("Hammer", 951, 20, 5);
        Product o2Product2 = new Product("Screwdriver", 753, 30, 10);
        Product o2Product3 = new Product("Insulating Tape", 456, 10, 30);
        o2Products.Add(o2Product1);
        o2Products.Add(o2Product2);
        o2Products.Add(o2Product3);
        Address c2Address = new Address("456 Gold Street", "Jundiai", "SP", "BR");
        Customer c2 = new Customer("John", c2Address);
        Order order2 = new Order(o2Products, c2);
        
        Console.WriteLine($"Order 2 - Packing Label:");
        List<string> o2Label = order2.GetPackingLabel();
        foreach (string info in o2Label)
        {
            Console.WriteLine(info);
        }
        Console.WriteLine($"Order 2 - Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        double o2TotalPrice = order2.GetTotalPrice();
        Console.WriteLine($"Order 2 - Total Price: ${o2TotalPrice}.");
    }
}