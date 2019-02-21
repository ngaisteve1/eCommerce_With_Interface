using System;

class DigitalProduct : IProduct
    {
        public string Title { get; set; }
        public bool OrderCompleted { get; private set; } = false;
        public int DownloadLeft { get; private set; } = 5;

        public void ShipItem(Customer customer)
        {
            if (!OrderCompleted)
            {
                Console.WriteLine($"Emailing {Title} to {customer.Email} ... ");
                OrderCompleted = true;
                DownloadLeft = DownloadLeft - 1;
                Console.WriteLine($"For {Title}, you have {DownloadLeft} download left.\n");
            }

        }
    }