public class Carr : Vehiclee
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Car engine stopped.");
    }
}