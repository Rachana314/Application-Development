public class Smartphone : ElectronicDevice
{
    public Smartphone(string brand, double price) : base(brand, price)
    {
    }

    public void EnableCamera()
    {
        Console.WriteLine("Smartphone camera activated.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Smartphone Brand: {Brand}, Price: Rs. {Price}");
    }
}