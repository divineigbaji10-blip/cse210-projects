using System.Collections.Generic;
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order (List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }
        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += ($"{product.Name} - {product.ProductId} \n");
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "";
        shippingLabel += ($"{_customer.Name} \n{_customer.GetAddress()}");
        return shippingLabel;
    }
}