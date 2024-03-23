namespace APBD_02.Classes;

using Interfaces;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool IsHazardous { get; set; }
    public LiquidContainer(double loadMass, double height, double containerWeight, double depth, double loadLimit, bool isHazardous)
        : base(loadMass, height, containerWeight, depth, loadLimit)
    {
        SerialNumber = $"KON-L-{ID}";
        IsHazardous = isHazardous;
    }

    public override void Load(double load) {
        if (IsHazardous) {
            if (LoadMass + load > LoadLimit * 0.5) {
                NotifyOfHazard(SerialNumber);
            }
        } else {
            if (LoadMass + load > LoadLimit * 0.9) {
                NotifyOfHazard(SerialNumber);
            }
        }
        base.Load(load);
    }

    public void NotifyOfHazard(string containerNumber) {
        Console.WriteLine($"Attention! Dangerous operation attempt in container {containerNumber}");
    }

    public override string ToString() {
        return base.ToString() + $", Hazardous: {IsHazardous}";
    }
}