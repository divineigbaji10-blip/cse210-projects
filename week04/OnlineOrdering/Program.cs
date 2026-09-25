using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Bourbon", "New Orleans", "Louisiana", "USA");
        Customer customer1 = new Customer("Paul", (address1));
        Product product1 = new Product("Gas Cooker", "C001", 100, 1);
        Product product2 = new Product("Samsung TV", "T223", 800, 1);
        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);
        Order order1 = new Order((products1), (customer1));

        Address address2 = new Address("Yonge", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Mary", (address2));
        Product product3 = new Product("Dishwasher", "D435", 700, 2);
        Product product4 = new Product("MacBook Pro", "P123", 1500, 2);
        List<Product> products2 = new List<Product>();
        products2.Add(product3);
        products2.Add(product4);
        Order order2 = new Order((products2), (customer2));

        Console.WriteLine("PACKING LABEL");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"TOTAL PRICE: ${order1.GetTotalPrice()}");
        
        Console.WriteLine();
        Console.WriteLine("==========================================");

        Console.WriteLine("PACKING LABEL");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"TOTAL PRICE: ${order2.GetTotalPrice()}");
    }
}