using System;



class Program
{
    static void Main(string[] args)

    {
        // ----- Greeting -----
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine(); 


        // ----- Order 1 (Johannesburg Customer) -----
        Address address1 = new Address(
            "332 Marlboro Dr, Lombardi",
            "Johannesburg",
            "Gauteng",
            "SA"
        );


        Customer customer1 = new Customer("Zefa B. Makenda", address1);


        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25.50, 2));


        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2} ");
        Console.WriteLine();


        Address address2 = new Address(
            "45 King Shak Street",
            "Durban",
            "KZ",
            "SA"
        );

        Customer customer2 = new Customer("Kalala Tshibangu", address2);


        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P2001", 150.00, 1));
        order2.AddProduct(new Product("USB Cable", "P2002", 10.00, 3));
        order2.AddProduct(new Product("Webcam", "P2003", 85.75, 1));


        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2} ");

    }

}
