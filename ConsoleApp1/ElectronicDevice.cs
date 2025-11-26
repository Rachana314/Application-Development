public abstract class ElectronicDevice
{
    private string? brand;
    private double price;

    public string? Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
            else
                Console.WriteLine("Price must be greater than 0");
        }
    }

    // Constructor to initialize brand and price
    public ElectronicDevice(string brand, double price)
    {
        Brand = brand;
        Price = price;
    }

    public abstract void ShowInfo();
}