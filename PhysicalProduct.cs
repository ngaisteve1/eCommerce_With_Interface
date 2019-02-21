using System;

class PhysicalProduct : IProduct
{
    public string Title { get; set; }
    public bool OrderCompleted { get; private set; } = false;

    public void ShipItem(Customer customer)
    {
        if (!OrderCompleted)
        {
            Console.WriteLine($"Shipping {Title} to {customer.Name} in {customer.City} ... ");
            OrderCompleted = true;
        }

    }
}