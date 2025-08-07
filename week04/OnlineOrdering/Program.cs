using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Order 1: Customer in USA
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("Alice Smith", address1);

        Product product1_1 = new Product("Laptop", "P001", 1200.00, 1);
        Product product1_2 = new Product("Mouse", "P002", 25.00, 2);
        Product product1_3 = new Product("Keyboard", "P003", 75.00, 1);

        List<Product> products1 = new List<Product> { product1_1, product1_2, product1_3 };
        Order order1 = new Order(products1, customer1);

        Console.WriteLine("--- Order 1 ---");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");

        // Order 2: Customer outside USA
        Address address2 = new Address("456 Oak Ave", "Othercity", "ON", "Canada");
        Customer customer2 = new Customer("Bob Johnson", address2);

        Product product2_1 = new Product("Monitor", "P004", 300.00, 1);
        Product product2_2 = new Product("Webcam", "P005", 50.00, 1);

        List<Product> products2 = new List<Product> { product2_1, product2_2 };
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("--- Order 2 ---");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}\n");
    }
}

