using APBD_02.Interfaces;

namespace APBD_02.Classes;

public class GasContainer : Container, IHazardNotifier
{
    private double Pressure { get; set; }
    public GasContainer(double loadMass, double height, double containerWeight, double depth, double loadLimit, double pressure)
        : base(loadMass, height, containerWeight, depth, loadLimit)
    {
        SerialNumber = $"KON-G-{ID}";
        Pressure = pressure;
    }

    public override double Unload() {
        double temp = LoadMass * 0.95;
        LoadMass -= temp;
        Console.WriteLine($"Unloaded {temp} kg from container {SerialNumber}");
        return temp;
    }

    public void NotifyOfHazard(string containerNumber) {
        Console.WriteLine($"Attention! Dangerous operation attempt in container {containerNumber}");
    }

    public override string ToString() {
        return base.ToString() + $", Pressure: {Pressure}";
    }
}