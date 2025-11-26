public class Laptop : ElectronicDevice
{
    public Laptop(string brand, double price) : base(brand, price)
    {
    }

    public void TurnOnBattery()
    {
        Console.WriteLine("Laptop battery is now ON.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Laptop Brand: {Brand}, Price: Rs. {Price}");
    }
}