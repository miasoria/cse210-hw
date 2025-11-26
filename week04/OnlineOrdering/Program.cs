using System;

class Program
{
    static void Main(string[] args)
    {
        // --- ORDER 1 (USA Customer) ---
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        Product p1 = new Product("Laptop", "L100", 1000, 1);
        Product p2 = new Product("Mouse", "M200", 50, 2);

        order1.AddProduct(p1);
        order1.AddProduct(p2);

        // --- ORDER 2 (International Customer) ---
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        Product p3 = new Product("Keyboard", "K300", 80, 1);
        Product p4 = new Product("Monitor", "M400", 200, 2);
        Product p5 = new Product("USB Cable", "U500", 10, 3);

        order2.AddProduct(p3);
        order2.AddProduct(p4);
        order2.AddProduct(p5);

        // --- DISPLAY RESULTS ---

        // Display Order 1
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalCost()}");

        // Display Order 2
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.GetTotalCost()}");
        Console.WriteLine("---------------------------------------------");
    }
}