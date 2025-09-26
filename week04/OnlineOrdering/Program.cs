using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        // creating products
        Product order1Prod1 = new Product("Pens", 001, 1.00, 20);
        Product order1Prod2 = new Product("Paper", 002, 0.05, 200);

        List<Product> order1ProdList = new List<Product>() { order1Prod1, order1Prod2 };

        // creating Customer
        // creating address for customer
        Address address1 = new Address("123 Dale Ave", "Vernal", "UT", "USA");
        Customer order1Customer = new Customer("John", address1);

        // creating order object
        Order order1 = new Order(order1ProdList, order1Customer);

        // printing shipping, packing, and total
        Console.WriteLine($"{order1.GetCustomerName()}'s Order");
        Console.WriteLine($"Packing label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost()}");

        // breaking line
        Console.WriteLine();

        // Order 2
        Product order2Prod1 = new Product("Onion", 003, 1.47, 5);
        Product order2Prod2 = new Product("Red Bell Pepper", 004, 2.50, 2);

        List<Product> order2ProdList = new List<Product>() { order2Prod1, order2Prod2 };

        // creating Customer
        // creating address for customer
        Address address2 = new Address("1234 Disney Rd.", "1-1 Maihama", "Urayasu", "Japan");
        Customer order2Customer = new Customer("David", address2);

        // creating order object
        Order order2 = new Order(order2ProdList, order2Customer);

        // printing shipping, packing, and total
        Console.WriteLine($"{order2.GetCustomerName()}'s Order");
        Console.WriteLine($"Packing label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost()}");
    }
}