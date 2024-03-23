namespace APBD_02.Classes;

using Exceptions;

public abstract class Container
{
    public static int _nextID = 0;
    public int ID { get; }
    public double LoadMass { get; set; }
    public double Height { get; }
    public double ContainerWeight { get; }
    public double Depth { get; }
    public string SerialNumber { get; set; }
    public double LoadLimit { get; }

    protected Container (double loadMass, double height, double containerWeight, double depth, double loadLimit)
    {
        LoadMass = loadMass;
        Height = height;
        ContainerWeight = containerWeight;
        Depth = depth;
        LoadLimit = loadLimit;
        ID = _nextID++;
    }

    public virtual double Unload()
    {
        double temp = LoadMass;
        LoadMass = 0;
        Console.WriteLine($"Unloaded {temp} kg from container {SerialNumber}");
        return temp;
    }

    public virtual void Load(double load)
    {
        if (load + LoadMass > LoadLimit)
        {
            throw new OverfillException($"Load limit exceeded in container {SerialNumber}");
        }
        else
        {
            LoadMass += load;
            Console.WriteLine($"Container {SerialNumber} now has load mass of {LoadMass} kg");
        }
    }

    public override string ToString()
    {
        return $"{GetType().Name}  -- ID: {ID}, Load: {LoadMass}, MaxLoad: {LoadLimit}, Height: {Height}";
    }
}