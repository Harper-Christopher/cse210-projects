using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", 9874, 2500, 2);
        Product product2 = new Product("Nintendo Swith", 4321, 400, 1);
        Product product3 = new Product("Model Y", 1234, 38000, 1);
        
        // Addresses
        Address address1 = new Address("2265 W 700 S", "Pleasant Grove", "UT", "USA");
        Address address2 = new Address("9200 Bridgeport Rd", "Richmond", "BC", "Canada");

        // Customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Order information
                Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Order 1\n");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 1 Total Cost: $" + order1.TotalOrderCost());
        Console.WriteLine("-----------------------------------------------------------");

        Console.WriteLine("Order 2\n");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 2 Total Cost: $" + order2.TotalOrderCost());
        Console.WriteLine("-----------------------------------------------------------");
    }
}