
public class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Car Brand: {Brand}, Speed: {Speed} km/h, Seats: {Seats}");
    }

    internal void StopEngine()
    {
        throw new NotImplementedException();
    }
}