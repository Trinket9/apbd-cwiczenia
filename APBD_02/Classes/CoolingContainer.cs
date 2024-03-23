using APBD_02.Interfaces;

namespace APBD_02.Classes;

public class CoolingContainer : Container, IHazardNotifier
{
    public static Dictionary<LoadType, double> ProductTemperatures = new Dictionary<LoadType, double>() {
        {LoadType.Bananas, 13.3}, {LoadType.Chocolate, 18}, {LoadType.Fish, 2},
        {LoadType.Meat, -15}, {LoadType.IceCream, -18}, {LoadType.FrozenPizza, -30},
        {LoadType.Cheese, 7.2}, {LoadType.Sausages, 5}, {LoadType.Butter, 20.5}, {LoadType.Eggs, 19}
    };

    private double Temperature { get; set; }

    private LoadType LoadType { get; set; }

    public CoolingContainer(double loadMass, double height, double containerWeight, double depth, double loadLimit, double temperature, LoadType loadType)
        : base(loadMass, height, containerWeight, depth, loadLimit) 
    {
        LoadType = loadType;
        SerialNumber = $"KON-C-{ID}";

        if (temperature < ProductTemperatures[loadType]) {
            Console.WriteLine($"Temperature in container {SerialNumber} was too low; set to minimum temperature for the given product ({ProductTemperatures[loadType]})");
        }
        Temperature = double.Max(temperature,ProductTemperatures[loadType]);
    }

    public void NotifyOfHazard(string containerNumber) {
        Console.WriteLine($"Attention! Dangerous operation attempt in container {containerNumber}");
    }

    public override string ToString() {
        return base.ToString() + $", Temp: {Temperature}, Holding: {LoadType}";
    }
}

public enum LoadType
{
    Bananas, Chocolate, Fish, Meat, IceCream, FrozenPizza, Cheese, Sausages, Butter, Eggs
}