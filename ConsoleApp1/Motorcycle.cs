public class Motorcycle : Vehicle
{
    public required string Type { get; set; }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Motorcycle Brand: {Brand}, Speed: {Speed} km/h, Type: {Type}");
    }
}