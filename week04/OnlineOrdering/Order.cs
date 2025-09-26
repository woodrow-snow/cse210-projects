using System.Net.WebSockets;
using System.Collections.Generic;

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product prod in _products)
        {
            total += prod.GetTotalCost();
        }

        // adding shipping cost
        if (_customer.DoesLiveInUS())
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
        string packingLabel = $"----------\n";
        foreach (Product prod in _products)
        {
            packingLabel += prod.GetPackingInfo() + "\n";
        }
        packingLabel += "----------";
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabal = "----------\n";
        shippingLabal += _customer.GetMailingAddress();
        shippingLabal += "\n----------";
        return shippingLabal;
    }

    public string GetCustomerName()
    {
        return _customer.GetName();
    }
}