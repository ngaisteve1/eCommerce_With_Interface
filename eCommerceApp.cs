using System;
using System.Collections.Generic;

class eCommerceApp
{
    public void Execute()
    {
        List<IProduct> cart = AddSampleData();
        Console.WriteLine($"Added {cart.Count} product into shopping cart.\n");

        Customer customer = GetCustomer();

        foreach (IProduct item in cart)
        {
            item.ShipItem(customer);
        }
    }

    private static Customer GetCustomer()
    {
        return new Customer { Name = "John", Email = "John@gmail.com", City = "Kuala Lumpur" };
    }

    private static List<IProduct> AddSampleData()
    {
        List<IProduct> listOfPhysicalProducts = new List<IProduct>() {
                new PhysicalProduct { Title = "iPhone 5"},
                new PhysicalProduct { Title = "iPhone 4s"},
                new DigitalProduct { Title = "Chinese song MP3"},
                new DigitalProduct { Title = "English song MP3"},
                new PhysicalProduct { Title = "MSI Laptop"}
            };

        return listOfPhysicalProducts;
    }
}