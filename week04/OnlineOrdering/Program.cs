using System;

class Program
{
    static void Main(string[] args)
    {
        //Create an address
        Address customerAddress = new Address("123 Main St", "Main Town", "CA", "90210", "USA");
        //Create a customer
        Customer customer1 = new Customer("1", "John", "Doe", "john.doe@example.com", customerAddress);
        //Create Products
        Product productA = new Product("101", "Laptop", 1200.00m, "Powerful laptop for work and gaming.");
        Product productB = new Product("102", "Mouse", 25.00m, "Ergonomic wireless mouse." );
        //Create an order
        Order order1 = new Order("1001", customer1);
        order1.AddProduct(productA);
        order1.AddProduct(productB);
        // Add order to customer's order list
        customer1.AddOrder(order1);
        // Display information
        Console.WriteLine(customer1);
        Console.WriteLine(customer1.ShippingAddress);
        Console.WriteLine(order1);
        Console.WriteLine("Products in Order:");
        foreach (var product in order1.Products)
        {
            Console.WriteLine($"- {product.Name} {product.Price:C}");
        }
    }
}