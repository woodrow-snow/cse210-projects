using System.Dynamic;
using System.Numerics;

class Product
{
    private string _name;
    private int _prodID;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _prodID = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return (double)_price * _quantity;
    }

    public string GetPackingInfo()
    {
        return $"{_name}, {_prodID}, quantity: {_quantity}";
    }
}