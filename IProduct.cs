public interface IProduct
{
    string Title { get; set; }
    bool OrderCompleted { get; }

    void ShipItem(Customer customer);
}